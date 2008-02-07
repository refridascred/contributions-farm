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

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
