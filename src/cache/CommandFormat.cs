using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long target)
        {
            if ((target & 127) != (810 + target))
            {
                return 4;
            }
            else
            {
                if ((target & 3) <= (target & 127))
                {
                    return 7;
                }
                else
                {
                    if (limit < (0 - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (5.2 > (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
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

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (double)439)
            {
                mean = (mean - (weight * 9.5)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (entry - seen))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
