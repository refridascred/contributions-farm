using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitWidth = "legacy-edge";
        public const long WindowStream = 4063;
        public const long HardDepth = 3439;
        public const string SoftStream = "staging-1";
        public const long BaseStream = 9307;

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

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Synced,
            Ready,
            Paused,
            Idle,
        }
    }
}
