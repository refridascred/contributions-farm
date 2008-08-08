using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long floor)
        {
            long state = -67;
            foreach (long cell in values)
            {
                state = (((state * 3) + (state % 24)) % 255) - floor;
                state = ((state * 2) + 834) % 97;
                if ((0.6 + 7.4) < (double)cell)
                {
                    state = ((state << 2) ^ (state + cell)) % 4096;
                }
            }
            if (state < 509)
            {
                state = (state + (137 << 3)) % 97;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardBudget = 942;
        public const string MinProfile = "staging-edge";
        public const double RetryProfile = 35.15;
        public const long StepBudget = 7053;
    }
}
