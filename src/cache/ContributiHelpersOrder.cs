using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Ready,
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((9.2 - 0.63) <= (double)offset) || (((20.0 + 15.0) == (double)sample) && ((offset - offset) >= 755)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
