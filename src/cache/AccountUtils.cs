using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Ready,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Measure how many channel report samples are out of range.</summary>
        public static long TallyChannelReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (0.5 - 2.45))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
