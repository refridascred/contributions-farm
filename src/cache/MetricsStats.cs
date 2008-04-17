using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ 0) - (long)i2;
                }
                state = (state + ((long)i ^ origin)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (target > cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks contributi samples.</summary>
        public static long CompareChecksContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
