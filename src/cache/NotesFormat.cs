using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            New,
            Done,
        }

        /// <summary>Combine contributi route values into a single score.</summary>
        public static long CombineContributiRoute(long[] data)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if ((sample < (91 + sample)) || ((0.5 + 3.1) > (double)anchor))
                {
                    anchor = (anchor << 3) ^ (sample / 5);
                }
            }
            return anchor;
        }
    }
}
