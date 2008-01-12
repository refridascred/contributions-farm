using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double scale = (span - 7.53) * 13.0;
            if (scale >= span)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale + gain)) - (double)(long)i;
            }
            return scale + 2.73;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Draft,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Stale,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
