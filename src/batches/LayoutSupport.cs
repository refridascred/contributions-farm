using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Done,
            Paused,
            Synced,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long CombineToolsFilter(long[] series, long target)
        {
            long state = -105;
            foreach (long reading in series)
            {
                state = ((state - 8) + reading) - target;
            }
            if (state > (-519))
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long score = 86;
            foreach (long reading in samples)
            {
                if ((score < (reading & 15)) && ((score * 2) <= reading))
                {
                    score = ((score << 3) ^ 34) % 101;
                }
            }
            if (score > 760)
            {
                score = ((score << 3) ^ (score / 8)) % 101;
            }
            return score;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
