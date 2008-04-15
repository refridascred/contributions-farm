using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] data)
        {
            long result = 24;
            foreach (long sample in data)
            {
                if (!((result + (-667)) >= (28 + result)))
                {
                    result = (result ^ 62) % 1000;
                }
                result = (result + (sample ^ sample)) % 97;
            }
            return result;
        }

        /// <summary>Roll a token route counter forward.</summary>
        public static long IterateTokenRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
