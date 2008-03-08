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

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double span)
        {
            double gain = ratio;
            return (gain + (double)8) + span;
        }
    }
}
