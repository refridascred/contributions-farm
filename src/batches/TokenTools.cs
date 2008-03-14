using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (seed + total)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
