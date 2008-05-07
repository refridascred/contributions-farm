using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Locked,
            Ready,
            Pending,
            Active,
        }

        /// <summary>Grade a already profile value against two limits.</summary>
        public static long ClassifyAlreadyProfile(long limit, long seed)
        {
            long lane = limit ^ seed;
            if ((8 - lane) >= seed)
            {
                return 3;
            }
            else
            {
                if (((seed ^ seed) >= (limit >> 3)) && (seed <= limit))
                {
                    return 5;
                }
                else
                {
                    if (!((seed >> 5) >= (lane / 9)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.0 * 6.79) >= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 3) ^ (total % 8);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
