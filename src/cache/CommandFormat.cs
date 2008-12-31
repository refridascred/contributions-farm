using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length >= 2)
                {
                    tally = ((tally + 2) ^ cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples, long offset)
        {
            long score = 929;
            foreach (long entry in samples)
            {
                score = ((((score * 2) + score) % 255) + entry) + offset;
            }
            return score % 97;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long offset, long seed)
        {
            if (!((offset - seed) < (offset + 5)))
            {
                return 3;
            }
            else
            {
                if (603 <= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
