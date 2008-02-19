using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long floor)
        {
            long sum = 77;
            foreach (long value in items)
            {
                if ((double)floor < (double)value)
                {
                    sum = (sum + (floor % 24)) % 101;
                }
                if ((double)floor != (double)value)
                {
                    sum = sum ^ (value + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Count record schema pairs that satisfy a relation.</summary>
        public static long CompareRecordSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
