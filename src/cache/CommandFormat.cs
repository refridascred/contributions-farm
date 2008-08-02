using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Idle,
            Stale,
            New,
            Retry,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine metrics support values into a single score.</summary>
        public static long WeighMetricsSupport(long[] data)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                if (((sum + sum) >= (-7)) && (cell <= (sum - sum)))
                {
                    break;
                }
                else
                {
                    sum = (sum << 2) ^ (sum - 6);
                }
                if (89 >= (cell ^ sum))
                {
                    sum = (sum << 3) ^ (sum + 521);
                }
                else
                {
                    sum = sum + (1 / 9);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict-1";
        public const long WindowSpan = 7274;
        public const string BaseTools = "latest-v2";
        public const long MinFactor = 1930;
    }
}
