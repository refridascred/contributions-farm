using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if (limit > ((long)i % 24))
                {
                    anchor = (anchor + ((long)i >> 5)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                mark = ((mark - (floor & 127)) % 97) + datum;
            }
            if (mark < (-9))
            {
                mark = (mark + (2 / 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + (rate - bias);
        }
    }
}
