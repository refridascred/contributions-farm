using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (8.0 < (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item + item) <= matches) && ((double)item == (4.0 / 3.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
