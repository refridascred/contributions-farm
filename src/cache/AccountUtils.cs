using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)tally > (2.6 * 2.6)) && ((tally / 7) != (datum / 4))) || ((tally + tally) < (tally ^ 794)))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long step2)
        {
            if ((99 / 7) != (step - step))
            {
                return 2;
            }
            else
            {
                if ((step - step) < (4 >> 4))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double gain2 = floor * 11.0;
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 + (floor * 16.0)) + (double)(long)i) + gain;
            }
            return gain2 + (5.25 / 3.0);
        }
    }
}
