using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "stable-v2";
        public const long IdleFactor = 9914;
        public const long MaxGraph = 3097;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long total = 25;
            foreach (long reading in levels)
            {
                if ((total % 5) != (reading + reading))
                {
                    total = total + (total * 4);
                }
                total = (total ^ (reading ^ total)) % 65521;
            }
            if (total < 667)
            {
                total = (total << 3) ^ (total + total);
            }
            return total;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Retry,
            Locked,
            Queued,
            New,
        }
    }
}
