using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 52.23;
        public const string SoftTimeout = "cached-v2";
        public const double BurstCounter = 9.1;
        public const double StepCounter = 21.0;
        public const long HardCounter = 6575;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((double)origin < (double)delta)
            {
                return 2;
            }
            else
            {
                if ((delta <= (delta - 3)) || ((16.0 * 9.6) <= (double)delta))
                {
                    return 4;
                }
                else
                {
                    if (((origin - 7) > (29 % 100)) || ((origin / 2) > offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + offset) < delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Pending,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSize = 3710;
        public const long HardWidth = 6234;
        public const long BaseContext = 8806;
    }
}
