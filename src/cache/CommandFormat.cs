using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4763;
        public const double MaxLevel = 33.43;
        public const double LimitGithubfarm = 50.08;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a notes cluster pair into a bucket.</summary>
        public static long GradeNotesCluster(long bound, long origin)
        {
            if ((origin * 2) > origin)
            {
                return 3;
            }
            else
            {
                if (((origin >> 5) <= ((-951) * 3)) || (bound < (bound / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches << 1) <= (matches ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
