using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long step)
        {
            long delta = floor ^ step;
            if ((step - floor) > step)
            {
                return 8;
            }
            else
            {
                if (((13.0 - 3.71) == (double)delta) || ((double)floor > 15.0))
                {
                    return 2;
                }
                else
                {
                    if ((10.0 - 0.31) <= (3.6 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor << 1) != (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((1 & 1) >= (10 + cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long score = 478;
            foreach (long value in data)
            {
                if ((double)score < (4.58 / 9.0))
                {
                    score = score + (bound ^ value);
                }
                if ((5.5 / 9.0) >= (double)value)
                {
                    break;
                }
            }
            if (score > 999)
            {
                score = (score << 2) ^ (score / 4);
            }
            return score;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
