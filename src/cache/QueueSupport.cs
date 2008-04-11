using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            New,
            Queued,
            Paused,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)bound != (double)(long)i))
                {
                    carry = (carry - bound) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long limit)
        {
            long mark = 47;
            foreach (long entry in data)
            {
                if ((double)entry >= (6.0 + 6.0))
                {
                    mark = ((mark << 2) ^ (mark - entry)) + limit;
                }
            }
            if (mark > 421)
            {
                mark = (mark + (mark ^ mark)) % 97;
            }
            return mark;
        }
    }
}
