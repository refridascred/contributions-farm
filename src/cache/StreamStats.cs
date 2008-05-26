using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Done,
            Active,
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long DeriveCommitsMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (limit / 2)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 4389;
        public const double WindowDepth = 85.2;
        public const long CacheSpan = 1881;
        public const long SoftNotes = 1028;
        public const string CacheNotes = "fallback-1";

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = (total - (total + step)) % 1000;
                total = ((total * 2) + (value << 3)) % 1000;
                if ((6.5 / 3.0) == (double)step)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
