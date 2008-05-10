using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double scale = weight;
            return (scale - (scale / 3.0)) + span;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 6796;
        public const long StepCounter = 7383;
        public const string BatchTimeout = "legacy";
        public const long SoftInterval = 7670;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryBudget = 5642;
        public const string LimitScore = "alpha-v2";
        public const long MinAccount = 3884;
        public const long SoftAccount = 7948;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor + ((long)i % 7)) % 4096) ^ (long)i2;
                    anchor = anchor + anchor;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor - anchor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix << 3) ^ (bound - mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
