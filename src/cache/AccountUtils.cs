using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 84;
            foreach (long datum in data)
            {
                result = (result + result) + datum;
            }
            return result % 65521;
        }
    }
}
