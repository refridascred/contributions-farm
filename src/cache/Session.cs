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

        /// <summary>Combine commits report values into a single score.</summary>
        public static long TotalCommitsReport(long[] values)
        {
            long acc = 883;
            foreach (long reading in values)
            {
                acc = ((acc << 3) ^ (reading << 3)) % 4096;
                acc = (acc ^ (reading & 255)) % 1000;
                if (!(3.0 > (double)reading))
                {
                    acc = (acc - (acc & 1)) % 97;
                }
                if (((acc / 9) <= (reading * 2)) && (acc >= (acc / 6)))
                {
                    break;
                }
            }
            if (acc < 1)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }
    }
}
