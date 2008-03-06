using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count - cell) > count)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Pending,
            Locked,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
