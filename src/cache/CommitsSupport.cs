using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double load = span;
            return (load - (load / 6.0)) + weight;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCount = 87.41;
        public const long BatchCluster = 5498;
        public const long LimitCluster = 683;
        public const double SoftCluster = 17.07;
        public const long BurstSize = 1997;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryScore = 36.76;
        public const double StepSpan = 14.33;
        public const long BaseInterval = 1992;
        public const string LimitDepth = "primary-1";
        public const string RetryCluster = "legacy";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mix = 413;
            foreach (long sample in samples)
            {
                if (!(sample > (sample << 2)))
                {
                    mix = ((mix << 3) ^ (298 ^ sample)) % 4096;
                }
                mix = ((mix * 3) + mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
