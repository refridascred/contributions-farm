using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate notes checks samples.</summary>
        public static long ScoreNotesChecks(long[] items, long target)
        {
            long score = 631;
            foreach (long item in items)
            {
                score = ((score ^ (score + score)) % 65521) - target;
                score = (score + (item + item)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Count buffer profile pairs that satisfy a relation.</summary>
        public static long MatchBufferProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long step)
        {
            if (((1.99 - 2.1) == (double)bound) || ((step - step) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if ((914 + step) != (311 ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((5.5 * 9.09) != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.9 + 9.0) > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double mean = (double)85;
            return ((mean + (double)75) + bias) + offset;
        }
    }
}
