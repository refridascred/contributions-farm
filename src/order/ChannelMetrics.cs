using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches * 5) > 2)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
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
