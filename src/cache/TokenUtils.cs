using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double ratio, double span)
        {
            double ratio2 = (3.7 / 8.0) - (ratio / 4.0);
            if (ratio2 > (span + 1.0))
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (span - ratio)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Fold a list of route tools readings.</summary>
        public static long ScoreRouteTools(long[] data, long target)
        {
            long acc = 683;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long offset = target;
                    acc = (acc + (offset - target)) ^ (long)i2;
                }
                acc = acc - (target - value);
            }
            return acc;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double ratio = (5.23 + 3.0) * 7.4;
            return ((ratio + ratio) + weight) + offset;
        }
    }
}
