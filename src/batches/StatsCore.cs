using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long MeasureFilterMetricHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell & 3) < (cell + hits))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter format value against two limits.</summary>
        public static long BucketFilterFormat(long origin, long limit)
        {
            long diff = origin + limit;
            if (origin <= (diff << 3))
            {
                return 2;
            }
            else
            {
                if ((limit & 31) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin + diff) >= (440 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Blend two session token measurements.</summary>
        public static double ScaleSessionToken(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (double)180)
            {
                rate = (rate - (scale / 7.0)) - offset;
            }
            else
            {
                rate = rate - (7.0 * 6.63);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 4.0)) - (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
