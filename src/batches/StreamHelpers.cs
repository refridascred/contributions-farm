using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate stream account readings against a bound.</summary>
        public static bool GuardStreamAccountRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9674;
        public const string MaxRecord = "latest-1";
        public const long MinRecord = 5010;
        public const double DefaultRecord = 31.77;
        public const long BatchDepth = 5363;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchTimeout = 59.01;
        public const double HardBuffer = 14.92;
        public const double MaxBudget = 47.79;
        public const double SoftBuffer = 62.34;
        public const long BaseRatio = 8230;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Active,
            New,
            Ready,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((3.4 > (double)(long)levels.Length) && (11.0 <= (double)cell)) || !((842 % 5) > (cell + bound)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command buffer reading.</summary>
        public static double BlendCommandBuffer(double bias, double bias2)
        {
            double gain = bias;
            return (gain + (15.0 * 4.8)) + bias2;
        }
    }
}
