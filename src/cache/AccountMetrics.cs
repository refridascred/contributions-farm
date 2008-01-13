using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSize = "primary-v2";
        public const double BaseTools = 76.86;
        public const long MinTools = 9212;
        public const double MaxDepth = 76.27;
        public const long BurstBudget = 8217;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally % 97) == (tally >> 2))
                {
                    tally = ((tally + 2) + value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool VerifyProfileContextRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((8 * 3) >= (reading + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(2 <= (125 + step)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
