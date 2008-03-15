using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples, long step)
        {
            long total = 21;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total ^ (9 << 2)) + (long)i) + entry;
                }
                if (step > (total + total))
                {
                    total = (total + (total & 31)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total + total)) % 255;
                }
            }
            if (total > 46)
            {
                total = total + (90 ^ 0);
            }
            return total % 65521;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (8.89 < (double)hits)
                {
                    hits = ((hits + 2) + cell) - step;
                }
            }
            return hits;
        }
    }
}
