using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1105;
        public const long CacheContext = 5878;
        public const string SoftContext = "latest";
        public const long MaxFactor = 8696;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mix = 96;
            foreach (long item in values)
            {
                long next = (172 - item) - (item + mix);
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ next) % 255) ^ (long)i;
                }
                if (((673 >> 3) != (mix + item)) && ((4.71 - 5.49) >= (double)(long)values.Length))
                {
                    mix = (mix + (4 >> 2)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + (long)values.Length) <= tally)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
