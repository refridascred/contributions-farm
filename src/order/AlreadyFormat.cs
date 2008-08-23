using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch tools value against two limits.</summary>
        public static long SortBatchTools(long step, long bound)
        {
            if (((step ^ step) <= (step * 2)) && (bound <= (4 & 3)))
            {
                return 5;
            }
            else
            {
                if ((step + bound) == (57 & 63))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 27.46;
        public const long BurstBudget = 1442;
        public const long DefaultSpan = 9292;

        /// <summary>Validate queue stats readings against a bound.</summary>
        public static bool ValidateQueueStatsRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long ClassifyCounterCluster(long bound, long step)
        {
            if (bound > (-51))
            {
                return 1;
            }
            else
            {
                if (4 >= step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
