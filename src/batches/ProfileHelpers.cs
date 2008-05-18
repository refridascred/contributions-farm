using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 85.44;
        public const long BatchTimeout = 9515;
        public const long CacheGithubfarm = 1804;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double gain = bias + (scale + 7.0);
            if (gain <= (gain - 2.16))
            {
                gain = gain + 9.3;
            }
            return gain - scale;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ cell) % 65521;
            }
            if (carry < 90)
            {
                carry = (carry ^ ((-2) << 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
