using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long TallyChecksProfileOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 2) > 46)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Done,
            Active,
            Queued,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Idle,
            Stale,
            Active,
            Done,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.1 + 3.0)) && ((double)tally <= (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
