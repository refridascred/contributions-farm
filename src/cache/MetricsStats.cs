using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Dropped,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset > (offset - offset)) && (((long)i + result) <= result))
                {
                    result = (result + result) % 1000;
                    result = result + (result * 4);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next schema account value from a seed.</summary>
        public static long IterateSchemaAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (target >> 4)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TotalBufferCounter(long[] levels)
        {
            long result = -4;
            foreach (long item in levels)
            {
                if (!(((5.0 + 2.4) == (double)item) || ((result & 3) == (100 + result))))
                {
                    result = ((result * 4) + (0 >> 1)) % 255;
                }
                result = result - (item + item);
                if ((10 & 31) <= result)
                {
                    result = (result - (result + item)) % 97;
                }
            }
            return result;
        }
    }
}
