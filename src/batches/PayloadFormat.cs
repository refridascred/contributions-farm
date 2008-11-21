using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + (reading * 5)) - origin;
            }
            return sum % 4096;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Count metric profile pairs that satisfy a relation.</summary>
        public static long PairMetricProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
