using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
