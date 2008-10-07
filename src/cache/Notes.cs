using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally < (double)bound)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Done,
            Dropped,
        }
    }
}
