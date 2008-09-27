using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                long diff = target;
                acc = (acc - (diff + target)) % 1000;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
