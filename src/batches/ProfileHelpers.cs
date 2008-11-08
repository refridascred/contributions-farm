using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.02 - 4.0) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Digest a series of order window entries.</summary>
        public static long FoldOrderWindow(long[] data, long offset)
        {
            long state = 568;
            foreach (long item in data)
            {
                if (((state / 2) == (state + item)) && (((-56) & 3) == (8 - item)))
                {
                    state = ((state + (item << 1)) % 97) + offset;
                }
                else
                {
                    state = ((state * 3) + (item / 5)) % 101;
                }
                if (!((state - 37) < (state >> 4)))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
