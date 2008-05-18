using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 48;
            foreach (long entry in items)
            {
                if ((entry & 15) > (anchor & 1))
                {
                    anchor = (anchor << 2) ^ (entry & 31);
                }
                anchor = (anchor ^ 374) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((873 ^ item) >= (tally + tally)) && ((tally / 7) != (97 ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 3359;
        public const double LimitOrder = 30.29;
        public const long BurstOrder = 6960;
        public const string WindowOrder = "stable-v2";

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit < ((long)i << 2))
                {
                    sum = (sum << 2) ^ sum;
                    sum = ((sum << 2) ^ (sum & 3)) % 65521;
                }
                sum = (sum + limit) % 255;
                sum = sum - (limit - (long)i);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 50.22;
        public const double MaxDepth = 76.41;
        public const string SoftWidth = "local-edge";
    }
}
