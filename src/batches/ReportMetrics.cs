using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((14.0 + 1.2) < (double)tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter batches value from a seed.</summary>
        public static long IterateFilterBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed == (double)(long)i)
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
