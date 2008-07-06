using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = mix + (long)i;
                long delta = mix;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix - 71) % 97) ^ (long)i2;
                    mix = (mix ^ (delta * 2)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "strict-edge";
        public const long BurstSize = 2441;
        public const long StepAccount = 279;
    }
}
