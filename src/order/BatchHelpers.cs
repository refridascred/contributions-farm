using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels)
        {
            long result = 151;
            foreach (long value in levels)
            {
                result = result - (value * 4);
                result = (result ^ 10) % 101;
                if (!((value + value) > (631 + 5)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
