using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double load = bias;
            return load - (span / 7.0);
        }

        /// <summary>Roll a checks cache counter forward.</summary>
        public static long DeriveChecksCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (offset + offset)) % 97;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
