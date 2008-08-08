using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (limit * 3);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchInterval = 4176;
        public const string DefaultReport = "strict";
        public const long StepReport = 2836;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 46.34;
        public const double RetryDepth = 61.76;
        public const string WindowWidth = "open-edge";
        public const string HardDepth = "local-edge";
    }
}
