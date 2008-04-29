using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings)
        {
            long score = 739;
            foreach (long value in readings)
            {
                if ((score % 64) > (score / 4))
                {
                    score = ((score * 4) + value) % 1000;
                }
            }
            return score;
        }

        /// <summary>Validate token format readings against a bound.</summary>
        public static bool ValidateTokenFormatBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            New,
            Dropped,
            Paused,
        }
    }
}
