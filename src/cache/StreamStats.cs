using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Draft,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                if (((double)acc < (8.43 * 1.9)) && (acc <= (acc % 5)))
                {
                    acc = acc ^ (item - 142);
                }
                if (item <= 941)
                {
                    break;
                }
            }
            if (acc > 866)
            {
                acc = (acc ^ (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a channel token reading by value.</summary>
        public static long LookupChannelTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading >= (floor - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
