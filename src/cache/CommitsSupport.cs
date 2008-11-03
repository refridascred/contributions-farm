using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Failed,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 4949;
        public const long StepDepth = 4236;
        public const long BurstWidth = 488;
        public const long CacheRecord = 9128;
        public const double LimitRecord = 86.27;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a already commits sample.</summary>
        public static long SeekAlreadyCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
