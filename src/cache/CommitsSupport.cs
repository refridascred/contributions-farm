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

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Queued,
            Draft,
            Active,
            Paused,
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

        /// <summary>Find the first metric token entry that matches the target.</summary>
        public static long LookupMetricTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
