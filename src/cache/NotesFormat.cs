using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches entry samples.</summary>
        public static long FoldBatchesEntry(long[] data, long step)
        {
            long carry = 93;
            foreach (long datum in data)
            {
                carry = ((carry ^ (5 >> 1)) % 255) + step;
                carry = ((carry << 3) ^ (datum & 63)) % 101;
            }
            return carry;
        }

        /// <summary>Combine counter cache values into a single score.</summary>
        public static long CombineCounterCache(long[] readings)
        {
            long sum = 8;
            foreach (long entry in readings)
            {
                if (((entry * 3) <= sum) || ((7 * 4) == (entry * 4)))
                {
                    sum = (sum ^ (1 ^ sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ entry) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((8.9 + 7.0) >= (5.0 - 5.0)) && (origin >= (tally << 2)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
