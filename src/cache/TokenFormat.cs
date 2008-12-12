using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count > (item - item)) || (((item - item) >= (item + target)) && ((10.0 * 2.9) <= (double)target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count order metric pairs that satisfy a relation.</summary>
        public static long CompareOrderMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
