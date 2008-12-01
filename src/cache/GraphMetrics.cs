using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double drift = gain;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (floor + 16.0)) - (double)(long)i;
            }
            return drift + (gain / 9.0);
        }
    }
}
