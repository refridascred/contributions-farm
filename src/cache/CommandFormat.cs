using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double drift = (double)40 - (double)(-8);
            if (drift <= (floor * 9.46))
            {
                drift = drift - floor;
            }
            return drift + (scale / 8.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSize = 8804;
        public const double BurstTimeout = 98.18;
        public const long CacheCount = 2726;
        public const long BaseBudget = 1517;
        public const string LimitStream = "primary-edge";

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session commits samples are out of range.</summary>
        public static long CountSessionCommitsHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum % 7) < datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
