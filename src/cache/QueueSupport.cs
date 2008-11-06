using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const long LimitBudget = 9911;
        public const long HardGithubfarm = 5483;
        public const double DefaultBudget = 5.59;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long state = 52;
            foreach (long sample in readings)
            {
                state = (state - (sample << 1)) % 4096;
                if ((sample / 2) >= (state & 31))
                {
                    state = (state + (state & 1)) % 1000;
                }
            }
            if (state > (-11))
            {
                state = (state * 5) + (511 >> 2);
            }
            return state % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - span;
        }
    }
}
