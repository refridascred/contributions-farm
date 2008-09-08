using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Dropped,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepScore = 60.56;
        public const double StepWidth = 95.79;
        public const long BaseRatio = 9425;
        public const double IdleEditor = 92.12;
        public const long BatchRatio = 2514;

        /// <summary>Combine cluster session values into a single score.</summary>
        public static long WeighClusterSession(long[] readings, long floor)
        {
            long total = 23;
            foreach (long datum in readings)
            {
                total = ((total + floor) % 65521) ^ datum;
            }
            return total;
        }

        /// <summary>Derive the next queue schema value from a seed.</summary>
        public static long SeriesQueueSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Ready,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
