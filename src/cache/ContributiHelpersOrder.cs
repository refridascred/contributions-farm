using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((floor + entry) > floor)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Closed,
            Stale,
            Ready,
        }
    }
}
