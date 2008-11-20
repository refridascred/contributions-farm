using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double rate = gain;
            if (rate < (double)50)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (span * 0.83);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(score < seed))
                {
                    score = (score << 2) ^ (1 - seed);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstScore = 2237;
        public const long StepAccount = 7789;
        public const long MinSize = 4439;
    }
}
