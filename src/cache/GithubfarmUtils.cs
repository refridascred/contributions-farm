using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double ratio = rate;
            if (ratio > (double)850)
            {
                ratio = (ratio - rate) + floor;
            }
            else
            {
                ratio = ratio + (double)7;
            }
            return ratio + ratio;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry - (68 % 24)) % 255) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Synced,
            Done,
        }
    }
}
