using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = acc ^ acc;
                if (!((acc & 3) < (datum ^ acc)))
                {
                    acc = (acc ^ (datum - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }
    }
}
