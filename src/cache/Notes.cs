using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Failed,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long offset2)
        {
            if (((double)offset2 <= 8.0) && (341 >= (offset & 3)))
            {
                return 2;
            }
            else
            {
                if (offset >= offset2)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5428;
        public const long LimitEditor = 5676;
        public const double IdleWidth = 5.17;
    }
}
