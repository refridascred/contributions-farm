using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long step)
        {
            if ((step + 601) == (bound + step))
            {
                return 5;
            }
            else
            {
                if (((double)step > (double)bound) && ((step - step) > step))
                {
                    return 3;
                }
                else
                {
                    if (33 > (bound * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 663;
        public const string CacheEntry = "staging-1";
        public const double WindowFactor = 36.12;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Queued,
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Synced,
            Ready,
            Stale,
        }
    }
}
