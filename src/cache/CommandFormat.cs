using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data, long target)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if (target >= (sample << 2))
                {
                    total = (total * 3) + (target ^ target);
                }
                else
                {
                    total = (total + (total & 7)) % 1000;
                }
            }
            if (total < 51)
            {
                total = ((total << 3) ^ (total - 2)) % 97;
            }
            return total;
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
