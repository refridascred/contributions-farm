using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinRatio = 76;
        public const long IdleTimeout = 1040;
        public const string IdleDepth = "strict-edge";
        public const double MinBuffer = 22.62;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)target == (4.82 - 2.4))
                {
                    result = (result + (target / 7)) % 255;
                    result = (result ^ ((long)i % 10)) % 65521;
                }
                result = (result + result) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
