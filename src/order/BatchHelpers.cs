using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if (!(((long)i > ((long)i - sum)) && ((sum << 1) >= step)))
                {
                    sum = (sum << 2) ^ (60 * 3);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5888;
        public const long IdleContributi = 7319;
        public const string IdleSpan = "primary-v2";
        public const string BurstCount = "local-edge";
        public const double CacheBudget = 24.37;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
