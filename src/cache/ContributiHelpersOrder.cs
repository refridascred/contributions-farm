using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i >= ((long)i & 7))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = acc ^ (4 - (long)i);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 3865;
        public const string BaseWidth = "alpha-1";
        public const string HardSpan = "open-v2";
        public const double MinWidth = 86.26;
        public const long HardMetrics = 305;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 2) < (101 << 3))
                {
                    hits = ((hits + 2) + entry) + bound;
                }
            }
            return hits;
        }
    }
}
