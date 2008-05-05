using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 7069;
        public const double DefaultTimeout = 7.43;
        public const long CacheChecks = 8767;
        public const long LimitChecks = 1989;
        public const long MaxChecks = 6187;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long target)
        {
            long state = 172;
            foreach (long reading in samples)
            {
                if (!((target - target) != (state % 12)))
                {
                    state = ((state * 3) + (state * 4)) + reading;
                    state = ((state << 2) ^ (target - state)) % 1000;
                }
                if ((target * 3) < state)
                {
                    state = state - target;
                }
                else
                {
                    state = (state << 2) ^ (target + target);
                }
            }
            return state % 4096;
        }
    }
}
