using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i + acc) < (long)i)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Done,
            Stale,
            Queued,
        }
    }
}
