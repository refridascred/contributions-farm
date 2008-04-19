using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double scale, double bias)
        {
            double ratio = (double)(7 << 2);
            if (ratio <= 9.0)
            {
                ratio = ((ratio + (double)(-591)) - scale) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 737;
            foreach (long entry in series)
            {
                total = (((total << 2) ^ (limit & 3)) % 97) ^ entry;
            }
            if (total > 87)
            {
                total = (total - (494 - limit)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many account cache samples are out of range.</summary>
        public static long CountAccountCacheGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((target <= (target * 4)) && ((14.0 * 15.0) <= (double)hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels, long bound)
        {
            long carry = 28;
            foreach (long sample in levels)
            {
                if (!((sample ^ carry) < (carry + 6)))
                {
                    carry = carry - (sample + 3);
                    carry = (carry + (sample + bound)) % 101;
                }
                if ((5.0 - 7.82) > (double)bound)
                {
                    carry = (carry - (bound & 127)) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ (sample << 1);
                }
            }
            if (carry < 2)
            {
                carry = carry - (665 + bound);
            }
            return carry % 65521;
        }
    }
}
