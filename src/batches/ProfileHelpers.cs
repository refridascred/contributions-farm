using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 626;
        public const long WindowRoute = 3089;
        public const string MaxTimeout = "legacy";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseRatio = "open-edge";
        public const long BurstBudget = 2628;
        public const long RetryTools = 3644;
    }
}
