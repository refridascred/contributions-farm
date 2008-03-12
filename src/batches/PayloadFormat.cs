using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio + span))
            {
                ratio2 = ratio2 - (span + 8.5);
            }
            return ratio2 + (ratio + ratio2);
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long MeasureTokenGithubfarmHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value <= (2.69 / 5.0))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitSize = "stable";
        public const string MaxChecks = "latest-1";
        public const double LimitChecks = 64.67;
        public const long MinScore = 4952;
        public const double HardChecks = 46.22;

        /// <summary>Rank notes metric input into a small class.</summary>
        public static long BucketNotesMetric(long target, long target2)
        {
            if ((target / 4) > target2)
            {
                return 3;
            }
            else
            {
                if (!(target > (target & 1)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
