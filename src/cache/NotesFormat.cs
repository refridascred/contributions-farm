using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 7451;
        public const string SoftBatch = "open-v2";
        public const long RetryFactor = 6599;
        public const string WindowRatio = "local";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 5384;
        public const string SoftGithubfarm = "stable-edge";
        public const long DefaultGithubfarm = 782;
        public const long IdleFactor = 3902;
        public const double IdleGithubfarm = 45.71;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
