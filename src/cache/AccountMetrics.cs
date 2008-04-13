using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double gain = ratio;
            return (gain + (ratio + gain)) + floor;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Queued,
            Stale,
            New,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxSpan = 3373;
        public const long BaseSpan = 7767;
        public const long BatchFactor = 1783;
        public const double WindowFormat = 65.66;

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "open";
        public const long BaseLayout = 1196;
        public const double HardSpan = 86.77;
        public const long IdleSize = 3228;
        public const string BurstLayout = "stable-v2";

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
