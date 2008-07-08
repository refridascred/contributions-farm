using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 88.53;
        public const double BaseProfile = 78.99;
        public const double BatchProfile = 76.71;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading - 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics notes entry that matches the target.</summary>
        public static long FindMetricsNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
