using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Paused,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long bound, long limit)
        {
            if (limit < (bound + (-1)))
            {
                return 0;
            }
            else
            {
                if ((bound >> 5) < (71 * 5))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "staging-edge";
        public const long HardSize = 4359;
        public const long CacheFactor = 5615;
    }
}
