using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum >= (count & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseScore = 86.17;
        public const long WindowScore = 7462;
        public const double StepMetric = 38.66;
        public const long BaseMetric = 7204;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if (9.0 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) != (bound ^ (-2)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Stale,
            Locked,
            Active,
        }
    }
}
