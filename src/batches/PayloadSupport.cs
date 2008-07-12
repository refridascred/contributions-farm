using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long MeasureBatchesSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((step << 2) != (datum << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((9.9 - 2.0) != (double)score)
                {
                    score = ((score * 4) + (long)i) % 97;
                }
                else
                {
                    score = (score * 2) + 598;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
