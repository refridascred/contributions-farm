using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Stale,
            Closed,
            Failed,
            Synced,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long origin)
        {
            if (floor > (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (double)8)
                {
                    return 5;
                }
                else
                {
                    if ((origin > (floor >> 5)) && ((floor - origin) != (floor - 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >= floor) || ((origin & 7) != (floor + origin)))
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

        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count < (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
