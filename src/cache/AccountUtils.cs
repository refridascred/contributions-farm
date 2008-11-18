using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            long span = seed - bound;
            if ((double)bound == (double)span)
            {
                return 3;
            }
            else
            {
                if ((4.0 + 4.0) <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 * 5.5) != (double)span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
