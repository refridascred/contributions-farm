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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
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
