using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((floor & 1) < ((-52) & 127)) || (floor >= ((-54) ^ tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
