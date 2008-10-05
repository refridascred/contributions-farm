using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Pending,
            New,
            Failed,
            Queued,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitBudget = "cached";
        public const double DefaultContext = 61.41;
        public const double DefaultScore = 77.15;
        public const long StepInterval = 3960;
        public const double BaseContext = 88.98;

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = (double)0 + 0.9;
            if (scale <= (bias / 9.0))
            {
                scale = scale + bias;
            }
            return scale - weight;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Locate a editor commits reading by value.</summary>
        public static long LocateEditorCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
