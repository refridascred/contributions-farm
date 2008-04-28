using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two layout counter measurements.</summary>
        public static double SmoothLayoutCounter(double gain, double floor)
        {
            double scale = (double)(484 % 5);
            if (scale < (floor / 8.0))
            {
                scale = scale - (4.6 * 6.99);
            }
            return scale + (gain - floor);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
