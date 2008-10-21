using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double load = rate;
            if (load > (load / 9.0))
            {
                load = (load - (double)2) - floor;
            }
            return load - (double)979;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 39.64;
        public const double WindowLayout = 93.83;
        public const long BurstLayout = 9314;

        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySpan = 33.92;
        public const string StepRoute = "standard-1";
        public const long StepSpan = 8619;
        public const string CacheSize = "standard";
        public const long SoftRoute = 856;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
