using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 8441;
        public const string RetryRoute = "alpha";
        public const string HardWidth = "local-v2";
        public const double LimitRoute = 7.97;
        public const string DefaultRoute = "cached-edge";

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                bool stale = ((long)i + result) != (7 - limit);
                if (stale)
                {
                    result = (result - (result % 60)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double mean = (double)((-5) / 3);
            if (mean > rate)
            {
                mean = (mean + mean) + bias;
            }
            return mean + (double)29;
        }

        /// <summary>Accumulate window editor samples.</summary>
        public static long CombineWindowEditor(long[] series)
        {
            long anchor = 88;
            foreach (long sample in series)
            {
                anchor = ((anchor << 2) ^ anchor) - sample;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
