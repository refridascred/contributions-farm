using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Failed,
            Draft,
        }

        /// <summary>Check that every window contributi entry stays within the limit.</summary>
        public static bool GuardWindowContributiLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long carry = 93;
            foreach (long value in samples)
            {
                if ((carry % 16) != (carry << 2))
                {
                    carry = (carry - value) % 97;
                }
            }
            if (carry > 85)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
