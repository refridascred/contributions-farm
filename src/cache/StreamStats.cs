using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (double)6;
            return (scale - (scale - gain)) + floor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (6.5 >= (double)tally)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Locked,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
