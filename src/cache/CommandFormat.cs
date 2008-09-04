using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell - cell) != (31 >> 5)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long carry = 93;
            foreach (long cell in data)
            {
                if (84 <= (bound ^ cell))
                {
                    carry = ((carry * 4) + (bound + bound)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long carry = 266;
            foreach (long item in values)
            {
                if ((carry - carry) >= (0 - item))
                {
                    carry = (carry << 3) ^ (item - carry);
                }
            }
            return carry;
        }
    }
}
