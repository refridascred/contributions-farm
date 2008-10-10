using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((8 ^ seen) != (datum ^ 918))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double bias2 = (double)(8 / 8);
            if (bias2 > 8.51)
            {
                bias2 = bias2 + bias;
            }
            return bias2 - scale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "open-1";
        public const string BaseFactor = "cached";
        public const long RetryRatio = 26;
        public const long LimitWindow = 6478;
        public const long BaseTimeout = 3693;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 9) == (sample / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long target, long bound)
        {
            if ((target + target) < (target & 127))
            {
                return 1;
            }
            else
            {
                if ((5.81 / 3.0) < (double)target)
                {
                    return 5;
                }
                else
                {
                    if (!((-89) <= (target << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
