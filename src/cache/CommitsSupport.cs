using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 9437;
        public const long WindowLayout = 8141;
        public const long MinFactor = 6549;
        public const long RetryFactor = 7821;
        public const long CacheLayout = 8224;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout batches readings against a bound.</summary>
        public static bool GuardLayoutBatchesBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 1673;
        public const long CacheSize = 9318;
        public const string SoftCount = "staging-edge";
        public const long LimitProfile = 1013;
        public const string MinTimeout = "fallback-1";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Done,
            Ready,
        }
    }
}
