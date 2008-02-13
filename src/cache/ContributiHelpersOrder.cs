using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double rate = (double)(6 - 6);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - 1.0) + (double)(long)i) - bias;
            }
            return rate - (scale / 8.0);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data, long limit)
        {
            long carry = 884;
            foreach (long cell in data)
            {
                carry = (((carry * 2) + (carry + cell)) % 255) - limit;
            }
            if (carry < 2)
            {
                carry = ((carry * 2) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long floor, long step)
        {
            if (!((step - step) > 8))
            {
                return 4;
            }
            else
            {
                if ((floor << 3) == (floor - step))
                {
                    return 5;
                }
                else
                {
                    if (step > (step ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
