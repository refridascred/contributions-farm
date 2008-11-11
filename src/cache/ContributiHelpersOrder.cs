using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Dropped,
            New,
            Failed,
            Closed,
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cluster already entries that pass the check.</summary>
        public static long CountClusterAlreadyOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading > 9)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}
