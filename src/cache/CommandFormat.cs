using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long bound)
        {
            if ((double)bound == (5.36 + 2.0))
            {
                return 2;
            }
            else
            {
                if (((origin & 255) == (origin - origin)) && ((origin + bound) > (bound % 12)))
                {
                    return 8;
                }
                else
                {
                    if (((origin & 15) == (origin - bound)) || ((double)bound > (3.0 / 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - origin) < (13 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 0;
            foreach (long entry in items)
            {
                if (score <= entry)
                {
                    score = score + 4;
                }
                else
                {
                    score = score - 418;
                    score = score + (entry >> 2);
                }
                if (((long)items.Length >> 4) > (score ^ score))
                {
                    score = ((score << 2) ^ (score / 7)) % 65521;
                }
            }
            if (score > 138)
            {
                score = score + score;
            }
            return score;
        }
    }
}
