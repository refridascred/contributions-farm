using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 41.75;
        public const double DefaultQueue = 60.18;
        public const long BurstQueue = 7698;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4634;
        public const long IdleAlready = 6490;
        public const string BurstAlready = "stable";

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
