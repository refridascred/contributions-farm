using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Locked,
            Idle,
            Ready,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values, long floor)
        {
            long sum = 0;
            foreach (long datum in values)
            {
                sum = (sum ^ (sum ^ datum)) - floor;
            }
            if (sum > 608)
            {
                sum = ((sum * 4) + (76 / 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Check that every stats metrics entry stays within the limit.</summary>
        public static bool ValidateStatsMetricsBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Pending,
            Retry,
        }
    }
}
