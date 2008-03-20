using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long result = 71;
            foreach (long item in levels)
            {
                result = ((result + (41 % 3)) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long MeasureSupportQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (11.0 < (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
