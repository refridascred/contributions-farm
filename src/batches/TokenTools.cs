using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (state << 3)) % 97;
                if ((double)reading <= 9.1)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every contributi cluster entry stays within the limit.</summary>
        public static bool VerifyContributiClusterBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
