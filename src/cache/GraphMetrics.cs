using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long bound)
        {
            if ((bound + 614) <= offset)
            {
                return 6;
            }
            else
            {
                if (((74 / 6) < (bound / 6)) && ((0 ^ offset) == (710 * 5)))
                {
                    return 5;
                }
                else
                {
                    if (31 < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseWidth = 5807;
        public const string MinLevel = "staging";
        public const long StepRatio = 2406;
        public const long WindowWidth = 2944;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long seed)
        {
            if (seed > (seed * 4))
            {
                return 7;
            }
            else
            {
                if (seed > (step * 2))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) >= (9 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "primary-v2";
        public const long MinSchema = 8387;
        public const long CacheInterval = 5794;
        public const string BurstSchema = "legacy";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Retry,
            Paused,
            Synced,
            Idle,
        }
    }
}
