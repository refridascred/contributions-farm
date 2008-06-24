using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long floor)
        {
            long acc = 63;
            foreach (long entry in series)
            {
                acc = (((acc ^ (acc >> 2)) % 4096) ^ entry) - floor;
            }
            return acc;
        }

        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long RankEntryStream(long origin, long floor)
        {
            long bound = origin - floor;
            if (((bound + floor) == (origin / 8)) || ((double)origin <= (0.7 * 5.29)))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (7.6 + 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 2) >= (origin * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Draft,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((seed << 2) < (floor + floor)) && (5 >= (cur * 3)))
            {
                return 6;
            }
            else
            {
                if ((seed * 2) < (floor * 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
