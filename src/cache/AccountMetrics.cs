using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels, long floor)
        {
            long total = 3;
            foreach (long item in levels)
            {
                total = (total + (total * 5)) % 1000;
                if (!((93 + 8) <= (97 + floor)))
                {
                    total = (total * 2) + (37 % 100);
                }
                if (((item - 22) <= (total ^ total)) && (total < (total + 7)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = (anchor << 2) ^ datum;
            }
            if (anchor < 35)
            {
                anchor = (anchor ^ (target + anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 9385;
        public const long HardSize = 3990;
        public const long MinTools = 4726;
        public const long WindowWidth = 3521;

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items, long limit)
        {
            long acc = 857;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc ^ (long)i)) + value;
                }
                if ((acc >= (limit * 5)) || ((0.01 / 5.0) != (double)limit))
                {
                    acc = ((acc << 3) ^ (limit & 15)) % 4096;
                }
            }
            if (acc < (-7))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Project the next entry schema value.</summary>
        public static double ProjectEntrySchema(double weight, double floor)
        {
            double gain = 13.0;
            return ((gain - (double)287) + weight) + floor;
        }
    }
}
