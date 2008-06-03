using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Failed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((step & 127) <= (sample + step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double floor)
        {
            double drift = rate / 9.0;
            if (drift > rate)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift - (double)990;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (rate - rate)) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 409;
            foreach (long datum in series)
            {
                acc = ((acc * 5) + (30 & 3)) - datum;
            }
            if (acc < 665)
            {
                acc = acc - (acc << 2);
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
