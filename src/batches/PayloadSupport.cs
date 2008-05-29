using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepInterval = 73.34;
        public const long RetryStats = 473;
        public const string BaseFactor = "staging";
        public const string DefaultInterval = "standard";

        /// <summary>Accumulate contributi githubfarm samples.</summary>
        public static long WeighContributiGithubfarm(long[] series)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if (!((double)value < (7.5 * 0.4)))
                {
                    mix = mix - (mix + mix);
                }
            }
            return mix;
        }
    }
}
