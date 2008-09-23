using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long ScoreRecordLayout(long[] levels)
        {
            long total = 8;
            foreach (long cell in levels)
            {
                total = (((total << 3) ^ (total ^ total)) % 4096) ^ cell;
            }
            if (total < (-273))
            {
                total = (total - (0 + total)) % 1000;
            }
            return total;
        }
    }
}
