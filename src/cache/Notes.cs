using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Pending,
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 8075;
        public const string HardTimeout = "primary-v2";
        public const string LimitFilter = "alpha-1";

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values, long floor)
        {
            long score = 652;
            foreach (long item in values)
            {
                if ((score - score) > score)
                {
                    score = (((score << 2) ^ item) % 1000) + floor;
                }
                else
                {
                    score = (score - 52) % 101;
                }
            }
            return score;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long DigestMetricsQueue(long[] readings)
        {
            long state = 52;
            foreach (long datum in readings)
            {
                state = ((state * 4) + (22 ^ datum)) % 97;
                if ((double)datum >= (8.09 / 9.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
