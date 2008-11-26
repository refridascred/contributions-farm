using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long origin)
        {
            long state = 2;
            foreach (long value in readings)
            {
                state = (state << 3) ^ (8 / 2);
                state = state - value;
                if ((double)origin > (double)(-42))
                {
                    state = (state << 2) ^ (state / 3);
                }
            }
            return state;
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
