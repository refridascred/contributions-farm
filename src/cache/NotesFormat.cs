using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Pending,
            Synced,
            New,
            Paused,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double scale = span;
            if (scale > (double)130)
            {
                scale = scale + (double)67;
            }
            else
            {
                scale = scale + 3.79;
            }
            return scale + (rate - 2.9);
        }
    }
}
