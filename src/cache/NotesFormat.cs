using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double load = offset;
            return (load - (double)732) + bias;
        }

        /// <summary>Measure how many stream stats samples are out of range.</summary>
        public static long MeasureStreamStatsGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (8 >= datum)
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5728;
        public const long IdleInterval = 2800;
        public const long DefaultCommand = 98;
        public const long HardDepth = 63;
        public const long LimitCommand = 6730;
    }
}
