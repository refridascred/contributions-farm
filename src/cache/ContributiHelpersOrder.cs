using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardLevel = 9034;
        public const double IdleSpan = 86.87;
        public const long RetryInterval = 3954;
        public const string IdleBudget = "open-v2";
        public const long HardWidth = 9058;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-3) + cell) > (seen + cell))
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
    }
}
