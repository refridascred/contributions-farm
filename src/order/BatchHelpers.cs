using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long floor)
        {
            long carry = -2;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + (5 + floor)) % 97;
                if (entry > carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long TallySupportToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
