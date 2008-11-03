using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 8702;
        public const double WindowContext = 25.24;
        public const long BaseSize = 9622;
        public const long DefaultContext = 5745;
        public const long BurstDepth = 3526;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data)
        {
            long sum = -7;
            foreach (long item in data)
            {
                if (item > (item - sum))
                {
                    sum = (sum ^ (12 + sum)) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + item);
                }
            }
            return sum;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Dropped,
            Idle,
            Done,
            Locked,
        }
    }
}
