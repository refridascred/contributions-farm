using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batch context entries that pass the check.</summary>
        public static long MeasureBatchContextGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)1 > (double)floor)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long AuditStreamSupportOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (bound >= tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
