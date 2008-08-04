using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long floor)
        {
            if (floor >= (floor ^ floor))
            {
                return 0;
            }
            else
            {
                if ((double)floor > (double)5)
                {
                    return 8;
                }
                else
                {
                    if (floor < 71)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 2) < (floor ^ target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (5 > (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 1.5) + (double)(long)i) + span;
            }
            return scale + (rate - rate);
        }
    }
}
