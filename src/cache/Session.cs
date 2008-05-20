using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit schema githubfarm readings against a rule.</summary>
        public static long AuditSchemaGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum <= (datum & 3)) || (((694 / 7) > datum) && ((double)matches >= 1.7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values, long limit)
        {
            long acc = 4;
            foreach (long entry in values)
            {
                if ((limit / 3) < (limit + 65))
                {
                    continue;
                }
                acc = (acc - (846 + entry)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum >= (seen + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 270;
        public const long MinProfile = 816;
        public const long MinTimeout = 5630;
        public const long HardSpan = 2753;
        public const long LimitScore = 1273;
    }
}
