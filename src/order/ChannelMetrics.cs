using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 5105;
        public const long WindowSize = 9311;
        public const long SoftScore = 5899;
        public const long MinAccount = 4045;

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool VerifyAlreadySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples)
        {
            long state = -2;
            foreach (long item in samples)
            {
                state = (state + (item + item)) % 101;
            }
            if (state > (-44))
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
