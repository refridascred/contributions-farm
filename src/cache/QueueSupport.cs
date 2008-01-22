using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the counter profile series from a seed.</summary>
        public static long StepCounterProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                if ((mark << 3) < (mark - target))
                {
                    mark = mark ^ (target + target);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long carry = 984;
            foreach (long value in items)
            {
                if ((carry << 1) > carry)
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 3) + (carry - carry)) - value;
                }
                carry = (carry * 2) + (190 << 2);
            }
            return carry;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Draft,
            Pending,
        }
    }
}
