using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((680 - 823) > item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Locked,
            Pending,
            Ready,
            Failed,
        }
    }
}
