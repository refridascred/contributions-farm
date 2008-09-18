using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 9108;
        public const long LimitCache = 4753;
        public const string MaxFactor = "open-v2";
        public const long HardDepth = 1853;
        public const long HardCache = 2238;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long SortOrderStream(long seed, long target)
        {
            if (((double)seed >= (2.1 / 5.0)) && ((target & 31) >= (target * 3)))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (4.3 * 7.7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
