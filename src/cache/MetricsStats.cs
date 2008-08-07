using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long floor)
        {
            long anchor = 5;
            foreach (long cell in series)
            {
                anchor = (((anchor << 2) ^ (floor - 99)) % 255) ^ cell;
            }
            return anchor;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series)
        {
            long state = 23;
            foreach (long datum in series)
            {
                if ((2.82 * 1.0) < (double)datum)
                {
                    state = (state - (datum & 255)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 30;
            foreach (long entry in items)
            {
                if ((entry << 2) <= (target / 3))
                {
                    sum = (sum ^ target) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((target / 2) < target)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
