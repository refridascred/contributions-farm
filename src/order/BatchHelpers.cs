using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Pending,
            Ready,
            Idle,
            Dropped,
        }
    }
}
