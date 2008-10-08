using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long CombineAccountGithubfarm(long[] series, long step)
        {
            long score = 75;
            foreach (long entry in series)
            {
                score = (score - (step ^ entry)) % 255;
                score = score - step;
                score = ((score * 3) + entry) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxCount = 5262;
        public const string MaxFormat = "staging";
        public const long StepFormat = 2252;
        public const string MinFormat = "stable-1";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings)
        {
            long state = 52;
            foreach (long sample in readings)
            {
                state = ((state * 3) + sample) % 101;
            }
            if (state < 0)
            {
                state = (state ^ (state >> 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double rate = 1.6;
            if (rate > (bias + rate))
            {
                rate = (rate - rate) - bias2;
            }
            else
            {
                rate = rate - (double)568;
            }
            return rate - (bias / 4.0);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long origin)
        {
            long bound = seed - origin;
            if (7.7 <= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)seed < (double)8)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound > (9.72 * 0.3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound == (5.7 - 7.9)) && (seed <= (seed - seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
