using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double rate2 = (double)(-33) + (6.31 / 2.0);
            if (rate2 > (rate2 - floor))
            {
                rate2 = rate2 + (rate2 + rate);
            }
            else
            {
                rate2 = rate2 - (floor / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - floor) + (double)(long)i;
            }
            return rate2 - 6.38;
        }

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long BucketCommitsEditor(long floor, long limit)
        {
            if ((limit ^ floor) != (limit << 3))
            {
                return 2;
            }
            else
            {
                if (18 < (floor ^ limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)limit <= (7.38 * 5.7)) || ((limit << 1) > (38 & 15)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((floor & 255) != (limit ^ floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((3 * 4) >= (step >> 1))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry graph figure with a bias.</summary>
        public static double BlendEntryGraph(double ratio, double span)
        {
            double rate = (double)(2 / 7);
            if (rate <= (double)65)
            {
                rate = (rate + span) - ratio;
            }
            return rate - (1.72 * 1.86);
        }
    }
}
