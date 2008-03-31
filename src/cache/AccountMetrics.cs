using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank already checks input into a small class.</summary>
        public static long RankAlreadyChecks(long floor, long target)
        {
            long delta = floor + target;
            if ((target ^ target) >= (floor - target))
            {
                return 6;
            }
            else
            {
                if ((delta / 9) > (956 - floor))
                {
                    return 5;
                }
                else
                {
                    if (!((target / 3) < floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first account channel entry that matches the target.</summary>
        public static long SeekAccountChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel stats readings against a rule.</summary>
        public static long TallyChannelStatsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value ^ value) < value) || !((value * 3) <= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up session cluster samples.</summary>
        public static long OverlapSessionClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
