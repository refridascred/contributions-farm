using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long target, long offset)
        {
            if ((target % 60) < offset)
            {
                return 1;
            }
            else
            {
                if ((4 - target) <= ((-86) + target))
                {
                    return 4;
                }
                else
                {
                    if ((target >= (target + 2)) || (9.8 <= (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinTimeout = 91.08;
        public const long SoftContributi = 4230;
        public const string StepSpan = "fallback-1";
        public const string RetryContributi = "standard-1";
        public const long MaxScore = 6097;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Active,
            Failed,
            Dropped,
        }
    }
}
