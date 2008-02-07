using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long carry = -696;
            foreach (long cell in levels)
            {
                long lane = carry;
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry << 3) ^ cell) - (long)i;
                    carry = (carry * 5) + (lane ^ 1);
                }
                if ((cell ^ carry) > (245 + cell))
                {
                    carry = (carry * 3) + (carry + cell);
                }
                else
                {
                    carry = (carry * 5) + (cell - cell);
                }
            }
            if (carry > 573)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((777 + cell) > (long)levels.Length) || ((44 + cell) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)floor < (20.0 * 6.0))
                {
                    result = (result + (-42)) % 255;
                    continue;
                }
                result = result - (floor ^ floor);
                result = result - result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
