using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count * 3) < (count & 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepLevel = 4193;
        public const string LimitFactor = "strict-v2";
        public const long CacheTools = 9247;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry > 86) || ((entry * 2) != (limit * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Dropped,
            Synced,
            Locked,
        }
    }
}
