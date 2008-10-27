using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 32.71;
        public const long DefaultRatio = 975;
        public const long DefaultAccount = 1410;
        public const long BaseBudget = 8309;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9 % 97) < (count + count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((956 * 2) != (value - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
