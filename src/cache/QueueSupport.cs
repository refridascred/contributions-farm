using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 1645;
        public const string MaxAlready = "staging-v2";
        public const long StepAlready = 6470;
        public const long WindowCount = 9555;

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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Synced,
            Pending,
            Ready,
        }
    }
}
