using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((double)limit < (0.08 - 5.0))
                {
                    break;
                }
                if (acc <= (151 - acc))
                {
                    acc = (acc << 3) ^ 615;
                    acc = ((acc * 3) + limit) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
