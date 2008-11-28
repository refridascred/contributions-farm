using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseFactor = 424;
        public const long RetryChannel = 3656;
        public const long CacheFactor = 380;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Closed,
            Active,
            Draft,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Draft,
            Queued,
            Pending,
            Locked,
        }
    }
}
