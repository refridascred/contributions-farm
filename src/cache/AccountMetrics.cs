using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine schema window values into a single score.</summary>
        public static long TallySchemaWindow(long[] values)
        {
            long sum = 69;
            foreach (long sample in values)
            {
                sum = (sum + (sample / 8)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long result = 10;
            foreach (long reading in items)
            {
                if (!((double)result < (3.69 / 4.0)))
                {
                    result = ((result - (origin + origin)) % 97) - reading;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Roll a batches stream counter forward.</summary>
        public static long StepBatchesStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (target < (target >> 1))
                {
                    anchor = ((anchor << 3) ^ ((long)i - (long)i)) % 97;
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + (2 << 1)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
