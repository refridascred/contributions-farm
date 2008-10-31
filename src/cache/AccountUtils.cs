using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((3.0 - 1.1) > (double)seed)
                {
                    result = (result ^ (-8)) % 1000;
                    result = (result << 3) ^ (482 ^ (long)i);
                }
                else
                {
                    result = ((result << 3) ^ (84 & 7)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Pending,
            Retry,
            Draft,
        }
    }
}
