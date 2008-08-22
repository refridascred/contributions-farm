using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double ratio = (bias - bias) - span;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias / 3.0)) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Stale,
            Synced,
            New,
            Locked,
        }
    }
}
