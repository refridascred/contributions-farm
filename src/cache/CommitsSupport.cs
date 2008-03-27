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

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryScore = 36.76;
        public const double StepSpan = 14.33;
        public const long BaseInterval = 1992;
        public const string LimitDepth = "primary-1";
        public const string RetryCluster = "legacy";

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public double Region { get; set; }
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
