using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long ClassifyLayoutCommits(long origin, long seed)
        {
            long step = origin - seed;
            if ((7.34 + 2.9) > (5.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((20 + 17) < (seed + 1)) && ((double)step == (9.93 * 3.0)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + seed) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double mean = (double)(36 * 2);
            if (mean < (double)510)
            {
                mean = (mean + (double)345) + weight;
            }
            else
            {
                mean = mean + span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (mean + span);
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > (long)i)
                {
                    total = (total - (total + (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
