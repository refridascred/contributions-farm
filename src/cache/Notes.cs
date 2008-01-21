using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
