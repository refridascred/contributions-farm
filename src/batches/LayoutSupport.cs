using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchDepth = 48.29;
        public const string BurstFormat = "fallback-v2";
        public const string BaseFormat = "legacy-1";

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a commits tools figure with a bias.</summary>
        public static double ProjectCommitsTools(double rate, double bias)
        {
            double mean = 9.0 / 7.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - bias) - (double)(long)i) - rate;
            }
            return mean + bias;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
