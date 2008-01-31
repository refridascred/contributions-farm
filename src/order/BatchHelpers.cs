using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 10.12;
        public const double LimitFactor = 82.67;
        public const long HardStats = 8179;
        public const string LimitRatio = "staging-edge";
        public const long MinStats = 1085;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (target > (6 & 7))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
