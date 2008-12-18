using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the notes metrics entries that pass the check.</summary>
        public static long TallyNotesMetricsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally + item) <= 840)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
