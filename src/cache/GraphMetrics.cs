using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool ValidateChecksSupportLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 2) ^ seed;
                if ((mix >> 5) < ((long)i * 4))
                {
                    mix = (mix << 2) ^ (seed + seed);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = mix - ((long)i2 << 2);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 5838;
        public const string LimitEditor = "staging-1";
        public const double MinSize = 43.31;
        public const double DefaultBudget = 82.19;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseScore = "stable";
        public const double StepBuffer = 8.25;
        public const long MinBuffer = 7031;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
