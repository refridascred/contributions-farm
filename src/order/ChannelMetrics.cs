using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate layout batch readings against a bound.</summary>
        public static bool GuardLayoutBatchRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels, long floor)
        {
            long mark = 58;
            foreach (long value in levels)
            {
                mark = ((mark + (mark - floor)) % 97) + value;
            }
            return mark % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
