using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long origin)
        {
            long slot = step ^ origin;
            if (((origin >> 2) <= slot) || ((slot ^ 69) < origin))
            {
                return 8;
            }
            else
            {
                if ((step % 10) < slot)
                {
                    return 2;
                }
                else
                {
                    if (((step << 3) > step) || ((14 + origin) >= (slot + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every batch window entry stays within the limit.</summary>
        public static bool VerifyBatchWindowLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
