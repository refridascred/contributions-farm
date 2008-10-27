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

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples, long limit)
        {
            long state = 742;
            foreach (long sample in samples)
            {
                state = ((((state << 3) ^ (141 - (long)samples.Length)) % 101) ^ sample) - limit;
            }
            return state;
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
