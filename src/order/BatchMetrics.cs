using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((seed + entry) <= (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series, long bound)
        {
            long total = 55;
            foreach (long reading in series)
            {
                if (bound >= (319 ^ bound))
                {
                    total = ((total ^ (total % 7)) % 4096) - reading;
                }
            }
            return total % 65521;
        }
    }
}
