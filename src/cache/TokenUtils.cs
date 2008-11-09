using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double weight = scale;
            if (weight < (double)(-77))
            {
                weight = weight + (bias / 4.0);
            }
            else
            {
                weight = weight - scale;
            }
            return weight + bias;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long CombineGithubfarmLayout(long[] data, long target)
        {
            long mark = 93;
            foreach (long cell in data)
            {
                if ((2 ^ mark) <= target)
                {
                    mark = ((mark - mark) % 1000) + cell;
                }
            }
            if (mark > 198)
            {
                mark = (mark ^ (mark >> 1)) % 101;
            }
            return mark;
        }
    }
}
