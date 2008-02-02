using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 9055;
        public const string BurstReport = "standard-edge";
        public const long StepFactor = 2781;
        public const string HardCount = "local";
        public const long LimitSpan = 263;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
