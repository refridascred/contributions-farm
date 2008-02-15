using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double bias = floor / 3.0;
            if (bias <= bias)
            {
                bias = (bias + floor) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
