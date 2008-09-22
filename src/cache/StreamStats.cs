using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long score = 15;
            foreach (long datum in levels)
            {
                if ((score / 3) == (datum / 8))
                {
                    score = (score + (datum + score)) % 4096;
                }
            }
            if (score < (-347))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long MatchToolsSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long bound)
        {
            if ((6 / 8) != (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((seed & 31) < 1)
                {
                    return 3;
                }
                else
                {
                    if (((double)bound >= (2.4 + 6.8)) || ((seed + (-440)) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
