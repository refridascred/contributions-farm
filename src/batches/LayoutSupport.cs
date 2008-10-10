using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of stream metrics readings.</summary>
        public static long TallyStreamMetrics(long[] data, long offset)
        {
            long mark = 6;
            foreach (long item in data)
            {
                mark = (((mark << 2) ^ ((long)data.Length - item)) % 65521) - offset;
            }
            return mark;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 9143;
        public const long DefaultSize = 38;
        public const long StepStream = 6303;

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
