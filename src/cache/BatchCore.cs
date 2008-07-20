using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((15.0 * 0.3) != (double)tally)
                {
                    tally = ((tally + 3) ^ value) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
