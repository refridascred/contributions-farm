using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((3 + floor) == (tally + tally)) && ((datum * 4) <= (982 & 15)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics batch reading.</summary>
        public static double SmoothMetricsBatch(double scale, double floor)
        {
            double ratio = scale - floor;
            if (ratio <= floor)
            {
                ratio = ratio + (6.3 - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)36) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool CheckToolsEntryBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Stale,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Queued,
            Closed,
            Pending,
        }
    }
}
