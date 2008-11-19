using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 3484;
        public const double RetryBudget = 77.92;
        public const string MaxLevel = "legacy-1";
        public const long MinSpan = 1742;

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long CountSessionCommandHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - matches))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 58.79;
        public const long MinFactor = 9604;
        public const string IdleSession = "open-v2";
        public const string IdleLevel = "latest";
        public const string WindowSession = "legacy-1";
    }
}
