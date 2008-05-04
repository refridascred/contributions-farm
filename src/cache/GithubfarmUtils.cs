using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((4.71 - 1.0) > (double)seen) || ((cell / 5) >= (cell & 127))))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long DeriveEntryTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (seed + carry)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstLevel = "latest-v2";
        public const long MinContributi = 2603;
        public const long SoftScore = 8876;

        /// <summary>Classify a metrics graph pair into a bucket.</summary>
        public static long BucketMetricsGraph(long seed, long floor)
        {
            if (((seed + seed) >= floor) && ((4.41 + 2.27) != (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) >= (floor - seed))
                {
                    return 7;
                }
                else
                {
                    if ((7 << 2) < (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= 123)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
