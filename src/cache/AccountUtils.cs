using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long value in samples)
            {
                if ((9.27 / 6.0) != (double)carry)
                {
                    carry = (carry << 3) ^ (carry - bound);
                }
                if (((carry + bound) != (783 + bound)) || ((double)value == (5.0 / 2.0)))
                {
                    break;
                }
            }
            if (carry < 6)
            {
                carry = carry - (bound + carry);
            }
            return carry;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > (rate2 + 7.71))
            {
                rate2 = rate2 - (double)7;
            }
            else
            {
                rate2 = rate2 - (floor + rate2);
            }
            return rate2 + (floor / 7.0);
        }
    }
}
