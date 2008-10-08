using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((57 % 24) > matches)
                {
                    matches = ((matches + 3) ^ datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchScore = 60.69;
        public const long MaxProfile = 3209;
        public const string IdleProfile = "local-edge";
        public const long DefaultProfile = 9141;

        /// <summary>Define record limits and defaults.</summary>
        public const double RetrySpan = 64.58;
        public const double StepRecord = 95.13;
        public const double RetrySize = 35.66;
        public const double BaseRecord = 15.67;
        public const long SoftCount = 5879;
    }
}
