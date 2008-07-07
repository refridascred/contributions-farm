using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Queued,
            Done,
            Draft,
        }
    }
}
