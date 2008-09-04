using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultTimeout = 43.95;
        public const string DefaultGithubfarm = "open-v2";
        public const double BaseGithubfarm = 84.57;
        public const double LimitGithubfarm = 9.84;
        public const string SoftGithubfarm = "staging-edge";

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
