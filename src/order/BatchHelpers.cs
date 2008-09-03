using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of cache command entries.</summary>
        public static long CombineCacheCommand(long[] items)
        {
            long carry = 929;
            foreach (long entry in items)
            {
                carry = carry ^ (entry % 97);
                if ((entry + entry) != (entry - entry))
                {
                    carry = (carry + (carry + carry)) % 4096;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
