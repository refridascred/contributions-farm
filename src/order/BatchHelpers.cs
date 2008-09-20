using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((2.3 / 4.0) <= (double)offset)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long target)
        {
            long result = 0;
            foreach (long value in samples)
            {
                if (((4.8 * 0.14) > (double)value) && ((8 + value) <= (result * 5)))
                {
                    result = ((result * 2) + (50 * 2)) + target;
                }
            }
            return result % 4096;
        }
    }
}
