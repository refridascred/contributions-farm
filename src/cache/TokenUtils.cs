using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long seed, long floor)
        {
            if ((double)floor < (4.02 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((seed >> 3) <= (seed + floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed <= 3.9)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Ready,
            Queued,
            Synced,
            Active,
        }
    }
}
