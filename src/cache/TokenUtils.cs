using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples, long limit)
        {
            long state = 71;
            foreach (long sample in samples)
            {
                if (limit >= state)
                {
                    state = ((state << 3) ^ (94 & 1)) ^ sample;
                }
                else
                {
                    state = state ^ 1;
                }
            }
            if (state < 42)
            {
                state = (state + (state >> 5)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate githubfarm farm readings against a bound.</summary>
        public static bool CheckGithubfarmFarmBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
