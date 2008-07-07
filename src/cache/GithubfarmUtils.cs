using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Done,
            Locked,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftInterval = 5681;
        public const long StepBuffer = 4437;
        public const long WindowInterval = 5374;
        public const long DefaultBuffer = 3166;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading * 2) < origin)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
