using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double load = ratio - 9.9;
            if (load <= 0.8)
            {
                load = load + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if (((double)cell <= (6.9 - 0.94)) || ((acc + acc) != (cell >> 3)))
                {
                    acc = (acc + cell) % 97;
                }
            }
            return acc;
        }

        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long SeriesRecordProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ (920 + seed);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry + (9 << 1)) % 65521) + (long)i2;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
