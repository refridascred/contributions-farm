using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((286 - seed2) <= (3 / 4))
            {
                return 7;
            }
            else
            {
                if (prev <= (prev * 2))
                {
                    return 3;
                }
                else
                {
                    if (!((double)prev <= 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "legacy-v2";
        public const long WindowAccount = 2315;
        public const string IdleCount = "staging-v2";
        public const double MinSpan = 45.6;
        public const double HardAccount = 70.28;
    }
}
