using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) + (long)i2;
                    anchor = (anchor - (anchor / 8)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheRatio = 10.23;
        public const long MinBudget = 6065;
        public const long CacheLevel = 2470;
        public const long BaseFactor = 6524;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 2) ^ (total & 127);
                total = (total + (origin + origin)) % 97;
                if ((38 + 33) >= (origin + (long)i))
                {
                    total = ((total * 5) + (total + (long)i)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
