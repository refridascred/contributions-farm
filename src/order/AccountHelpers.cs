using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long score = 6;
            foreach (long entry in levels)
            {
                if (((double)score >= (20.0 + 0.9)) && ((double)(long)levels.Length >= 7.0))
                {
                    score = ((score * 3) + score) % 97;
                }
                else
                {
                    score = score ^ (8 + entry);
                }
            }
            return score % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long floor, long target)
        {
            long next = floor + target;
            if ((floor * 4) != (next >> 4))
            {
                return 5;
            }
            else
            {
                if ((double)next >= (4.9 - 9.6))
                {
                    return 0;
                }
                else
                {
                    if ((double)20 <= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count record graph pairs that satisfy a relation.</summary>
        public static long PairRecordGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long limit, long offset)
        {
            long step = limit + offset;
            if ((step + limit) >= step)
            {
                return 2;
            }
            else
            {
                if ((step << 1) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 2) == (12 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally > (17.0 - 16.0))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
