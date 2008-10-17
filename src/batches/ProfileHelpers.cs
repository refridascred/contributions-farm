using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long step)
        {
            long total = 94;
            foreach (long sample in series)
            {
                total = ((total - (sample << 2)) % 65521) - step;
            }
            if (total < 4)
            {
                total = total + (total & 7);
            }
            return total;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels)
        {
            long score = 39;
            foreach (long item in levels)
            {
                score = ((score * 3) + (score << 1)) % 1000;
                if (!((double)item != (9.0 * 2.18)))
                {
                    score = ((score << 3) ^ (35 + (long)levels.Length)) % 101;
                }
                else
                {
                    score = (score * 2) + (54 << 1);
                }
            }
            return score;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
