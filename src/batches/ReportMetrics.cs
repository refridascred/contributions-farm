using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 70.63;
        public const long StepSize = 8955;
        public const long BatchScore = 8992;
        public const string BurstProfile = "latest-v2";

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already metric entries that pass the check.</summary>
        public static long AuditAlreadyMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum >= (tally >> 3)) || ((datum + datum) <= (tally << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
