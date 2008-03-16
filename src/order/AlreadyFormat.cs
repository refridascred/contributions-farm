using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i == (double)offset)
                {
                    total = ((total << 3) ^ (total << 1)) % 65521;
                    total = (total * 5) + total;
                }
                else
                {
                    total = (total + ((long)i / 3)) % 101;
                    total = (total - ((long)i + 75)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of checks route readings.</summary>
        public static long FoldChecksRoute(long[] values)
        {
            long sum = 93;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (sum << 1)) - cell;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "alpha-edge";
        public const long DefaultGraph = 6546;
        public const long RetrySize = 9781;
        public const double WindowFactor = 57.07;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
