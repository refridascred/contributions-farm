using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a githubfarm report counter forward.</summary>
        public static long DeriveGithubfarmReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)acc < (7.7 * 0.56)))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = (score - (step / 2)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score << 2) ^ (long)i) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double span)
        {
            double gain = ratio;
            return (gain + (double)8) + span;
        }
    }
}
