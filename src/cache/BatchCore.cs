using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a cluster session value against two limits.</summary>
        public static long SortClusterSession(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((1.1 >= (double)limit2) && (780 >= (6 + edge)))
            {
                return 3;
            }
            else
            {
                if ((16.0 / 4.0) > (double)limit2)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8174;
        public const double RetryStats = 30.76;
        public const string LimitInterval = "cached";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9379;
        public const double StepBuffer = 67.48;
        public const string BaseBuffer = "open-1";
        public const long BatchTimeout = 342;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((floor + matches) < (item * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
