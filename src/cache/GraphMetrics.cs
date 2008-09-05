using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long offset)
        {
            long state = 82;
            foreach (long sample in levels)
            {
                state = (((state * 4) + state) + sample) + offset;
            }
            return state % 4096;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double rate = (offset * 13.0) + (weight / 2.0);
            if (rate > (double)33)
            {
                rate = rate + 9.34;
            }
            else
            {
                rate = rate - 6.64;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (offset - weight)) + (double)(long)i;
            }
            return rate - (2.8 - weight);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series, long target)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ carry) + cell) + target;
            }
            return carry;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
