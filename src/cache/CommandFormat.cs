using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series)
        {
            long anchor = 226;
            foreach (long entry in series)
            {
                if ((3.5 * 8.8) == (double)anchor)
                {
                    anchor = ((anchor + 35) % 4096) - entry;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitTimeout = "local-edge";
        public const long MinWidth = 8862;
        public const long LimitLevel = 8430;
        public const long WindowFormat = 2523;
        public const string SoftLevel = "staging";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardWidth = "staging-v2";
        public const string SoftReport = "stable-edge";
        public const double MinReport = 53.44;
        public const long SoftSpan = 9811;
    }
}
