using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 51.94;
        public const string BatchScore = "local-1";
        public const string IdleBudget = "strict";
        public const long CacheInterval = 8390;
        public const long MaxInterval = 2801;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Queued,
            Pending,
            Done,
            Active,
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
