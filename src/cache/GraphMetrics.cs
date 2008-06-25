using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry record readings.</summary>
        public static long FoldEntryRecord(long[] series, long floor)
        {
            long total = 787;
            foreach (long value in series)
            {
                total = (((total << 2) ^ (floor * 5)) % 255) - value;
                total = ((total * 5) + (total * 5)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ (carry << 1)) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
