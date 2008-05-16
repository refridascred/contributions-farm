using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if ((9.4 * 13.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((target * 2) > target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 2) ^ (acc ^ bound)) % 65521;
                if (((long)i - acc) >= (bound / 9))
                {
                    acc = acc ^ bound;
                    continue;
                }
                if (!((acc / 2) != (acc + 77)))
                {
                    acc = ((acc * 4) + (64 >> 2)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long origin, long bound)
        {
            if ((bound / 9) < (origin >> 2))
            {
                return 0;
            }
            else
            {
                if ((bound - (-34)) >= (55 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (bound <= (origin - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
