using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Active,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 9428;
        public const string HardRoute = "open-v2";
        public const string IdleRoute = "latest-v2";
        public const double BurstRoute = 38.97;
        public const long WindowRoute = 6303;

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state * 5) + (reading - reading)) % 1000;
            }
            if (state > (-673))
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
