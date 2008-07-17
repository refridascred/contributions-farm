using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSpan = 6174;
        public const long HardSchema = 3998;
        public const long MaxSchema = 436;
        public const long StepSchema = 1903;
        public const double WindowSchema = 96.33;

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
