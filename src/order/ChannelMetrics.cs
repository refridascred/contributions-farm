using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((seen / 6) >= (limit ^ limit)))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double bias)
        {
            double bias2 = 1.82;
            if (bias2 >= (double)649)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - (bias * 8.2);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias - gain)) - (double)(long)i;
            }
            return bias2 + (gain - gain);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + (long)i)) % 97;
                mark = mark + 586;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (mark % 97)) % 97) ^ (long)i2;
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
