using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cache graph measurements.</summary>
        public static double AdjustCacheGraph(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (bias * 0.2);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item % 7) < (seed - matches)) && ((2.61 - 6.68) != (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long bound)
        {
            if ((offset - bound) != (bound % 10))
            {
                return 0;
            }
            else
            {
                if (bound >= (bound + offset))
                {
                    return 3;
                }
                else
                {
                    if (bound > (offset + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (8.9 * 10.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long limit)
        {
            if (!((double)limit > (7.53 * 8.69)))
            {
                return 7;
            }
            else
            {
                if ((limit & 15) <= (limit ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
