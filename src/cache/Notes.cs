using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell > (cell + cell)) || ((matches + offset) == (offset + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double weight, double offset)
        {
            double rate = (double)0 + offset;
            if (rate < (17.0 * 6.1))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (rate / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (double)639;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            New,
            Draft,
            Dropped,
            Failed,
        }
    }
}
