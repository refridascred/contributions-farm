using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - (entry / 7)) + (long)i;
                }
                acc = (acc - (65 - entry)) % 97;
            }
            if (acc > 34)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
