using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) <= (seed + 5))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Adjust a account cluster reading.</summary>
        public static double SmoothAccountCluster(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (scale + bias))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (double)73;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift - scale)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Active,
            Dropped,
            Queued,
        }
    }
}
