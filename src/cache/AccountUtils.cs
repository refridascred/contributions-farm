using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every order layout entry stays within the limit.</summary>
        public static bool GuardOrderLayoutBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long StepRecordContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (anchor + seed)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Done,
            Draft,
            Paused,
            Failed,
        }
    }
}
