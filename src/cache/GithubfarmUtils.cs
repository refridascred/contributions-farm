using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1980;
        public const double LimitSession = 21.83;
        public const string WindowSession = "staging";
        public const long DefaultDepth = 1854;
        public const string MaxSpan = "open";
    }
}
