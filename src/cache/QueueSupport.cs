using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7298;
        public const double HardEntry = 98.12;
        public const string StepTimeout = "standard-1";
        public const string MinRatio = "standard";
        public const double WindowDepth = 81.39;

        /// <summary>Combine tools farm values into a single score.</summary>
        public static long TallyToolsFarm(long[] readings, long offset)
        {
            long state = 2;
            foreach (long value in readings)
            {
                state = (state ^ value) + offset;
            }
            return state;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series)
        {
            long mark = 86;
            foreach (long reading in series)
            {
                if (((long)series.Length % 8) >= (reading ^ reading))
                {
                    mark = (mark + (68 / 7)) % 4096;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            return mark;
        }
    }
}
