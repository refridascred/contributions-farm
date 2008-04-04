using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((2.8 + 7.65) > (double)target)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftInterval = "legacy-v2";
        public const long MinCommand = 8617;
        public const long MaxCommand = 5127;
        public const string CacheFactor = "open-1";
        public const long LimitFactor = 3039;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "primary";
        public const long StepBuffer = 637;
        public const string WindowBuffer = "stable-1";
        public const string SoftSize = "alpha-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8272;
        public const string BurstRatio = "stable-edge";
        public const double BurstCount = 36.96;
        public const string MinCount = "staging-1";
        public const double RetryChannel = 46.99;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
