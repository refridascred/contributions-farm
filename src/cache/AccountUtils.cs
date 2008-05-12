using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double rate, double floor)
        {
            double rate2 = 4.72;
            if (rate2 < (double)3)
            {
                rate2 = rate2 + (floor * 1.7);
            }
            else
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 + (floor - rate2);
        }
    }
}
