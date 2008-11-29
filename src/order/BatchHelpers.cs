using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double rate = (span - scale) + (scale * 15.0);
            return rate - (rate - span);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Stale,
            Idle,
            New,
        }
    }
}
