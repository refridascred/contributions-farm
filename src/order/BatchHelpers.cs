using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long span = bound - offset;
            if ((span + bound) >= (89 + offset))
            {
                return 5;
            }
            else
            {
                if ((double)bound >= (20.0 * 4.07))
                {
                    return 8;
                }
                else
                {
                    if ((double)621 < (double)span)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell < 4.04)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 65.31;
        public const long CacheFactor = 8932;
        public const long BatchCommits = 1264;
        public const long LimitRatio = 2324;
    }
}
