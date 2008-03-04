using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (13.0 / 2.0))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate entry profile readings against a bound.</summary>
        public static bool VerifyEntryProfileBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Locked,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
        }
    }
}
