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

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardScore = "strict";
        public const double IdleDepth = 90.23;
        public const double RetryCount = 95.48;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long anchor = 64;
            foreach (long item in samples)
            {
                if ((6 + anchor) != (item >> 4))
                {
                    anchor = anchor ^ (limit * 3);
                }
            }
            return anchor % 1000;
        }
    }
}
