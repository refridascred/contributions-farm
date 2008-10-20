using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 1518;
        public const long CacheSpan = 5619;
        public const string HardWidth = "alpha-1";
        public const long WindowStream = 3589;
        public const double StepStream = 5.0;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long offset)
        {
            if (!((0 - origin) != (offset + origin)))
            {
                return 5;
            }
            else
            {
                if (offset <= (origin % 60))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (0.1 - 7.2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Done,
            Retry,
            Pending,
        }
    }
}
