using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Closed,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstFactor = 28.52;
        public const double MinScore = 73.72;
        public const long DefaultAlready = 1456;
        public const long BatchAlready = 6784;

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long floor)
        {
            long prev = seed + floor;
            if ((floor >> 2) >= floor)
            {
                return 2;
            }
            else
            {
                if (((double)prev <= (0.39 - 19.0)) || ((seed - prev) > floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (2.4 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor <= (8.0 / 8.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
