using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate channel stats samples.</summary>
        public static long FoldChannelStats(long[] data, long target)
        {
            long state = 293;
            foreach (long reading in data)
            {
                state = (state + ((-6) ^ target)) % 4096;
                if ((double)reading >= (16.0 + 5.88))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Synced,
            Active,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count & 3) >= item) || (((-5) - item) < (555 + item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
