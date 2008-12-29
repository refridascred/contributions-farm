using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(((tally - cell) <= tally) && ((cell - (long)levels.Length) == (tally + 153))))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            long next = seed + origin;
            if (((49 + seed) >= next) || ((double)next > (4.0 - 18.0)))
            {
                return 1;
            }
            else
            {
                if (((double)next > (17.0 - 2.9)) && ((origin ^ origin) <= next))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin <= (double)569)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Stale,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long sum = 26;
            foreach (long reading in readings)
            {
                if ((sum * 2) > (sum * 3))
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 97) - reading;
                }
                else
                {
                    sum = (sum - (2 ^ sum)) % 97;
                }
            }
            if (sum < 731)
            {
                sum = ((sum * 4) + (sum - sum)) % 255;
            }
            return sum % 97;
        }
    }
}
