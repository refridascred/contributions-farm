using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen >> 4) < (497 >> 4)) && ((double)seed == (2.31 + 19.0)))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long origin)
        {
            long slot = floor + origin;
            if (((7 * 3) != (floor + origin)) && ((31 ^ slot) >= (49 * 5)))
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (6.4 * 3.08))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > 5.7)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)slot != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftDepth = 18.83;
        public const double DefaultAccount = 82.86;
        public const string StepAccount = "alpha-v2";
        public const long MinAccount = 8390;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((884 >> 3) >= (count / 3))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ 522) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
