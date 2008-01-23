using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ (carry + seed)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long total = 86;
            foreach (long datum in series)
            {
                if ((datum / 8) < (total & 127))
                {
                    total = total + datum;
                }
                else
                {
                    total = total - total;
                }
                if (datum < (total << 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultWidth = "standard-1";
        public const double CacheCounter = 28.04;
        public const long BatchCounter = 9079;
        public const long MaxCounter = 8209;
        public const long DefaultDepth = 6207;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((191 + seen) > (seen + seen))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
