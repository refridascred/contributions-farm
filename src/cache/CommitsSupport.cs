using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftDepth = "legacy-v2";
        public const long HardLevel = 2142;
        public const double BurstReport = 71.84;
        public const string DefaultDepth = "latest-1";

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Ready,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseDepth = 67.7;
        public const string RetryMetrics = "fallback-1";
        public const double CacheMetrics = 64.78;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
