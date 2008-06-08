using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            if (((floor ^ floor) > (floor / 4)) || ((origin * 5) < (floor / 8)))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) >= 4)
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 4) <= (origin / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((24 < (floor + origin)) || (origin <= (origin << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool CheckCounterContextBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
