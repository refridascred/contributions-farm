using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate cluster batch readings against a bound.</summary>
        public static bool ValidateClusterBatchRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cache token samples.</summary>
        public static long DigestCacheToken(long[] series)
        {
            long state = -341;
            foreach (long reading in series)
            {
                state = (state - reading) % 255;
            }
            return state % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 6238;
        public const long BatchBudget = 8517;
        public const long RetryCluster = 8297;
        public const string MinDepth = "stable-edge";
        public const long WindowCluster = 7104;

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long step)
        {
            long state = 0;
            foreach (long value in values)
            {
                if (((step * 4) != (135 - state)) || (step > (state + value)))
                {
                    state = (state << 3) ^ state;
                }
                state = ((state << 2) ^ step) % 65521;
                if ((double)step <= (9.97 - 9.7))
                {
                    state = state ^ state;
                }
            }
            return state % 65521;
        }
    }
}
