using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double gain = span;
            if (gain > (double)4)
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (span * 8.23)) + (double)(long)i;
            }
            return gain + 2.08;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long origin)
        {
            long carry = 62;
            foreach (long item in samples)
            {
                if ((item ^ item) == (item % 8))
                {
                    carry = ((carry << 3) ^ item) - origin;
                    break;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Roll a filter batches counter forward.</summary>
        public static long SeriesFilterBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (carry << 3)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = 45;
            foreach (long cell in levels)
            {
                if ((acc % 97) >= (acc + cell))
                {
                    acc = (acc << 2) ^ 14;
                }
                else
                {
                    acc = (acc + (acc + (long)levels.Length)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
