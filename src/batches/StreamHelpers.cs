using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheInterval = 6389;
        public const double HardScore = 27.95;
        public const string DefaultMetric = "standard-edge";
        public const long BurstDepth = 4180;
        public const long DefaultScore = 6216;

        /// <summary>Measure how many support checks samples are out of range.</summary>
        public static long MeasureSupportChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (322 >= (hits << 3))
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if ((total > (total - total)) || ((total ^ (-8)) < (3 << 2)))
                {
                    total = ((total * 3) + (total - total)) ^ cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of counter schema readings.</summary>
        public static long WeighCounterSchema(long[] levels)
        {
            long state = -17;
            foreach (long cell in levels)
            {
                if ((cell * 3) <= 748)
                {
                    state = ((state << 3) ^ cell) % 4096;
                }
            }
            if (state < 9)
            {
                state = ((state << 2) ^ (state - state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long step2)
        {
            long next = step - step2;
            if ((step ^ 407) != (next >> 2))
            {
                return 7;
            }
            else
            {
                if ((0 / 5) >= step2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
