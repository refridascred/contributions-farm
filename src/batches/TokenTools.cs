using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 6500;
        public const long CacheCounter = 4143;
        public const string WindowCounter = "strict-v2";
        public const double SoftInterval = 8.78;
        public const long StepCounter = 4852;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
