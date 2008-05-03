using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Queued,
            New,
            Draft,
            Active,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
