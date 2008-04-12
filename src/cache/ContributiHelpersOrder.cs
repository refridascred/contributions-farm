using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if ((double)offset < (9.84 - 13.0))
            {
                return 5;
            }
            else
            {
                if (offset > (target & 7))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 545;
        public const long StepFactor = 1637;
        public const long BurstSpan = 3329;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
