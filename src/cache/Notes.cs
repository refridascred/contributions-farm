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

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Dropped,
        }
    }
}
