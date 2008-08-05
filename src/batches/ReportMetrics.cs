using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mix = -666;
            foreach (long value in readings)
            {
                if ((value > (mix << 3)) && ((9.0 + 6.91) == (double)mix))
                {
                    continue;
                }
                if (value <= (long)readings.Length)
                {
                    mix = (mix * 2) + value;
                    mix = (mix - (mix * 3)) % 97;
                }
                mix = ((mix * 4) + (mix << 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 82.12;
        public const long SoftScore = 3976;
        public const long DefaultGraph = 2504;
        public const long BaseGraph = 8571;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((bound ^ total) < ((long)i % 8)) && ((double)bound >= (double)total))
                {
                    total = total - (total ^ bound);
                }
                else
                {
                    total = (total - ((long)i ^ (long)i)) % 4096;
                    total = total ^ (long)i;
                }
                total = (total + (bound << 3)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
