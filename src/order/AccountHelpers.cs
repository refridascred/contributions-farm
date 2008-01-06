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

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples)
        {
            long state = 846;
            foreach (long sample in samples)
            {
                if (2.8 >= (double)sample)
                {
                    state = (state - (sample % 24)) % 65521;
                }
                else
                {
                    state = (state * 5) + (sample << 2);
                }
                if (sample > (state % 100))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Draft,
            Paused,
            Stale,
            Active,
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
