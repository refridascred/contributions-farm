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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = carry ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
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
