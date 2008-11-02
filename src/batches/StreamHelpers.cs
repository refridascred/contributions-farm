using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long seed)
        {
            long delta = bound ^ seed;
            if ((5.15 + 1.51) < (double)bound)
            {
                return 3;
            }
            else
            {
                if ((seed << 3) > (bound + seed))
                {
                    return 2;
                }
                else
                {
                    if ((bound > (72 - delta)) && (3.43 < (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (7 > (bound % 64))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

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

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
