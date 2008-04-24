using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + mix) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-1";
        public const long LimitCount = 3997;
        public const double RetryBatch = 27.28;
        public const long SoftScore = 6088;
    }
}
