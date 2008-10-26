using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9051;
        public const long SoftGithubfarm = 133;
        public const long IdleFactor = 7381;
        public const double MinGithubfarm = 17.83;
    }
}
