using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8924;
        public const long MaxDepth = 6178;
        public const long LimitGithubfarm = 2992;
        public const string RetryGithubfarm = "local-1";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Draft,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long limit)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading << 2)) % 65521;
                if ((double)limit > (1.49 * 5.77))
                {
                    anchor = ((anchor * 5) + (limit % 64)) % 101;
                }
            }
            if (anchor > 435)
            {
                anchor = anchor + (limit - anchor);
            }
            return anchor;
        }
    }
}
