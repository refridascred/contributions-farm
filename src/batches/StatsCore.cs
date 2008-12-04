using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowScore = 8597;
        public const long RetryBuffer = 9569;
        public const long BaseCount = 9937;
        public const long DefaultCount = 4207;

        /// <summary>Validate commits order readings against a bound.</summary>
        public static bool ValidateCommitsOrderRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (((double)limit != (14.0 * 12.0)) || ((352 % 100) <= (bound2 & 3)))
            {
                return 7;
            }
            else
            {
                if (bound > (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((bound + limit) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate payload profile readings against a bound.</summary>
        public static bool GuardPayloadProfileLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
