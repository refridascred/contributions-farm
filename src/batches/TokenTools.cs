using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double gain = bias;
            return (gain + 18.0) + scale;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double load = 20.0 / 9.0;
            return (load + bias2) + bias;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values, long bound)
        {
            long state = -8;
            foreach (long value in values)
            {
                state = (state ^ bound) ^ value;
            }
            return state;
        }
    }
}
