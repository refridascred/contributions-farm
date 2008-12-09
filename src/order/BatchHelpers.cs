using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the account counter series from a seed.</summary>
        public static long StepAccountCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitBudget = 8981;
        public const long CacheTools = 5926;
        public const double CacheTimeout = 5.54;
        public const long LimitCount = 3638;
        public const long IdleTools = 4301;
    }
}
