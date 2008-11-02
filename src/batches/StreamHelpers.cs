using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchScore = 8302;
        public const double BurstFarm = 67.85;
        public const string MinScore = "standard-v2";

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Rank support counter input into a small class.</summary>
        public static long RankSupportCounter(long seed, long floor)
        {
            long diff = seed - floor;
            if ((seed - 13) > floor)
            {
                return 1;
            }
            else
            {
                if (!((double)diff < (9.7 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    if (((seed + diff) == (diff * 2)) && (17 < diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (697 + 40))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
