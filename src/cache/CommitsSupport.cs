using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a command token reading by value.</summary>
        public static long LookupCommandTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Draft,
            Synced,
            Retry,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "fallback";
        public const double MaxChecks = 42.52;
        public const long BurstLevel = 225;

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 80.33;
        public const long IdleScore = 2119;
        public const long SoftCount = 5529;

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if ((759 + (-90)) < mark)
                {
                    mark = (mark - datum) % 4096;
                }
                if ((47 - mark) <= (595 << 3))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Retry,
            Pending,
            Draft,
            Queued,
        }
    }
}
