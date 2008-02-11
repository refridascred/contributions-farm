using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 2) >= (floor >> 4))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8484;
        public const long HardGraph = 491;
        public const string BaseSize = "local";
        public const string StepGraph = "stable-v2";
        public const double LimitBudget = 64.82;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Locked,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 28.93;
        public const double WindowNotes = 98.54;
        public const long MaxLevel = 3312;
        public const long CacheRatio = 1788;
    }
}
