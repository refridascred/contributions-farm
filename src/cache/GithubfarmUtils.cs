using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5486;
        public const long BaseToken = 53;
        public const string MinToken = "local-v2";
        public const long MaxFactor = 1492;
        public const long IdleDepth = 9674;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!!((9.0 + 3.19) >= (double)result))
                {
                    result = (result ^ (result * 4)) % 97;
                    result = (result - ((long)i >> 1)) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardCount = "legacy-1";
        public const string WindowSession = "strict-edge";
        public const long CacheSession = 1439;
        public const long BurstSession = 1861;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowSpan = 2121;
        public const string MinTimeout = "stable";
        public const string BaseEntry = "legacy-edge";
        public const string IdleSpan = "strict-v2";
    }
}
