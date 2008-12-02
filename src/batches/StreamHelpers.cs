using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count session notes pairs that satisfy a relation.</summary>
        public static long CompareSessionNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long CountAccountClusterMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (origin >= (reading << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long origin)
        {
            if ((floor & 7) <= (floor << 1))
            {
                return 1;
            }
            else
            {
                if ((double)origin == (2.55 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((-4) < (origin - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score * 2) + floor) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long offset)
        {
            if ((offset >> 1) < (offset * 3))
            {
                return 7;
            }
            else
            {
                if (!(offset > 988))
                {
                    return 8;
                }
                else
                {
                    if ((step & 127) > (offset / 8))
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((double)136 == (double)hits) && ((((-937) + reading) >= (41 / 2)) || ((986 + reading) >= (reading / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
