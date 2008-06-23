using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - (double)15;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSize = 2159;
        public const double MinAlready = 10.49;
        public const string RetryAlready = "primary-1";
        public const long BatchAlready = 6620;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
