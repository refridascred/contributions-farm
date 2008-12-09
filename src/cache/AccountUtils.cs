using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits counter series from a seed.</summary>
        public static long SeriesCommitsCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit - limit) <= (total >> 4))
                {
                    total = (total ^ (long)i) % 1000;
                }
                else
                {
                    total = (total ^ limit) % 65521;
                }
                total = (total + (523 & 15)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count metric layout pairs that satisfy a relation.</summary>
        public static long OverlapMetricLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Pending,
            Done,
            Failed,
        }
    }
}
