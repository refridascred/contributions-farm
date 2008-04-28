using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (6.33 * 4.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitInterval = 6849;
        public const long IdleWidth = 2049;
        public const long StepRoute = 3456;
        public const double IdleRoute = 61.87;
        public const long WindowWidth = 2422;
    }
}
