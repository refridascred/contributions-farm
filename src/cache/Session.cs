using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstRatio = 5389;
        public const long LimitRatio = 8913;
        public const string BatchChecks = "latest-1";
        public const double MaxChecks = 3.67;
        public const double MinSize = 77.13;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - floor;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
