using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first metric record entry that matches the target.</summary>
        public static long LookupMetricRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats support input into a small class.</summary>
        public static long GradeStatsSupport(long step, long bound)
        {
            if (((bound & 31) > (18 << 1)) || ((3.84 - 1.0) != (double)bound))
            {
                return 6;
            }
            else
            {
                if ((step - bound) == (532 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound + 106) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "staging-1";
        public const long MinRecord = 8441;
        public const string HardInterval = "primary-1";
    }
}
