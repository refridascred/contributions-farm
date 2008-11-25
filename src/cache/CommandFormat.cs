using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Rank tools notes input into a small class.</summary>
        public static long ClassifyToolsNotes(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((double)cur <= 5.72)
            {
                return 8;
            }
            else
            {
                if (cur >= limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if (((335 ^ state) == (sample + state)) || ((double)sample <= (double)state))
                {
                    state = (state + (state ^ 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
