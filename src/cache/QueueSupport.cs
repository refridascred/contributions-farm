using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples, long floor)
        {
            long state = 921;
            foreach (long value in samples)
            {
                if ((9.1 / 5.0) <= (double)value)
                {
                    state = ((state << 2) ^ (2 >> 2)) - floor;
                }
                if ((9.8 - 6.4) == (double)value)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6326;
        public const long LimitScore = 6468;
        public const long BatchFormat = 5332;
        public const long BurstFormat = 1577;
    }
}
