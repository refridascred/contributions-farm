using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (0.81 >= (double)count)
                {
                    count = ((count + 2) + item) + floor;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 1660;
        public const long LimitSchema = 6963;
        public const long BatchTimeout = 1498;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Check that every order commits entry stays within the limit.</summary>
        public static bool CheckOrderCommitsBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Pending,
            Stale,
            Idle,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
