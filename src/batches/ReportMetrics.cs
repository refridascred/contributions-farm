using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((0.47 - 5.4) >= (double)carry)
                {
                    carry = (carry + (limit << 2)) % 65521;
                    carry = ((carry << 3) ^ (limit & 15)) % 255;
                    continue;
                }
                carry = (carry ^ (carry ^ (long)i)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i >= anchor))
                {
                    long next = anchor;
                    anchor = (anchor * 5) + next;
                }
                anchor = anchor - ((long)i * 3);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((0 - hits) <= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }
    }
}
