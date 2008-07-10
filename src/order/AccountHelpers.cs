using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool VerifyToolsContextLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 4) + (acc & 31);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (total - (long)i)) % 101;
                total = ((total << 2) ^ (total + bound)) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
