using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels)
        {
            long acc = 510;
            foreach (long item in levels)
            {
                acc = acc + (item + 268);
            }
            return acc;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                long offset = (carry << 3) - (limit + (long)i);
                if (!(offset >= (limit >> 4)))
                {
                    carry = carry - (limit - limit);
                    carry = (carry ^ (6 / 4)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate payload editor samples.</summary>
        public static long TotalPayloadEditor(long[] items)
        {
            long score = 246;
            foreach (long entry in items)
            {
                if ((score <= (score + entry)) || ((87 - entry) >= (score & 63)))
                {
                    score = score - entry;
                }
            }
            if (score > 41)
            {
                score = (score + (score << 1)) % 4096;
            }
            return score;
        }
    }
}
