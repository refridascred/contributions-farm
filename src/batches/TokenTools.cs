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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double span)
        {
            double gain = ratio;
            return (gain + (double)8) + span;
        }
    }
}
