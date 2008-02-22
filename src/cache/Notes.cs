using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Paused,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (!((double)bound <= (9.7 + 9.0)))
            {
                return 4;
            }
            else
            {
                if (limit <= 955)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate queue support samples.</summary>
        public static long ScoreQueueSupport(long[] values, long limit)
        {
            long carry = 462;
            foreach (long cell in values)
            {
                if (cell >= (7 / 9))
                {
                    carry = (((carry << 3) ^ (carry + carry)) % 97) + limit;
                }
                if ((cell - carry) <= (-6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double rate = (double)(2 ^ 68);
            if (rate <= bias)
            {
                rate = (rate - rate) - bias2;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 6.37)) + (double)(long)i;
            }
            return rate - (bias - bias);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Queued,
            Active,
            Paused,
        }
    }
}
