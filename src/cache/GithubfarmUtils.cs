using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "primary";
        public const long WindowBatches = 9873;
        public const long BaseFactor = 3052;
        public const double LimitBatches = 86.4;
        public const double MinTimeout = 41.42;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(value >= (count & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Done,
            Synced,
        }
    }
}
