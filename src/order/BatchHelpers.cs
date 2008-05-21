using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(809 < datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Pending,
            Paused,
        }
    }
}
