using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((seed + reading) != (996 + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
