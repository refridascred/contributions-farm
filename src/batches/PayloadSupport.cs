using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool GuardNotesCacheRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
