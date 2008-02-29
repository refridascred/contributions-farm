using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items)
        {
            long carry = 7;
            foreach (long reading in items)
            {
                carry = (carry - (815 << 3)) - reading;
            }
            if (carry < 881)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
