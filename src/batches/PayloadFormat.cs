using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next channel stream value from a seed.</summary>
        public static long IterateChannelStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target * 5) > (carry % 60))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((6.8 + 0.6) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    state = (state - ((long)i % 7)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
