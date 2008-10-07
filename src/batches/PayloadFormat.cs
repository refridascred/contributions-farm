using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double load = (double)(2 + 2);
            for (int i = 0; i < 3; i++)
            {
                load = (load - (7.87 + bias)) + (double)(long)i;
            }
            return load - (floor - bias);
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long step, long bound)
        {
            long slot = step - bound;
            if ((8.24 < (double)bound) || ((bound * 5) != (bound ^ step)))
            {
                return 3;
            }
            else
            {
                if ((895 & 31) >= (slot + bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up stats queue samples.</summary>
        public static long MatchStatsQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if ((target <= (18 >> 1)) && ((double)(long)i <= (7.56 + 3.91)))
                {
                    score = (score ^ (score / 4)) % 4096;
                    score = (score << 3) ^ target;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
