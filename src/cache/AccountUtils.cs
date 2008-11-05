using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (!((47 ^ (-431)) == (seed % 8)))
            {
                return 0;
            }
            else
            {
                if (((5.92 / 2.0) > (double)seed) || ((offset / 7) < (bound + bound)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Draft,
            Failed,
            Synced,
        }
    }
}
