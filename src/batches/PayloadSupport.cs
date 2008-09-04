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

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((15.0 <= (double)hits) || (((double)entry == (double)target) && ((double)entry != (4.66 / 2.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
