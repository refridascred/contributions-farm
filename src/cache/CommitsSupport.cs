using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Pending,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long DigestCacheChecks(long[] samples)
        {
            long state = 37;
            foreach (long value in samples)
            {
                if ((value % 3) <= (state ^ state))
                {
                    state = (state + (state / 6)) % 101;
                }
                if ((double)854 == (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] series, long target)
        {
            long score = 5;
            foreach (long item in series)
            {
                if ((9.6 * 11.0) == (double)item)
                {
                    score = score - target;
                }
            }
            if (score < 5)
            {
                score = score + (score + 518);
            }
            return score % 4096;
        }
    }
}
