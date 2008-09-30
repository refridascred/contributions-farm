using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long carry = 56;
            foreach (long sample in values)
            {
                carry = ((carry - (1 * 4)) % 4096) + sample;
            }
            return carry;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double drift = bias2 - (6.7 + 5.8);
            return (drift + (drift + 1.0)) + bias;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long origin2)
        {
            if ((origin << 3) > (654 ^ origin2))
            {
                return 1;
            }
            else
            {
                if ((1.82 * 1.0) > (double)origin2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
