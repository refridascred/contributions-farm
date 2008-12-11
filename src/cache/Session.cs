using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (origin >= (count - (-900)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
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
