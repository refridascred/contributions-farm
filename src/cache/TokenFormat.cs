using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long step)
        {
            if (((step + 49) < target) || ((9.35 - 20.0) != (double)step))
            {
                return 1;
            }
            else
            {
                if ((14.0 + 1.48) != (double)step)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
