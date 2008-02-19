using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long bound)
        {
            long carry = 132;
            foreach (long sample in data)
            {
                if ((1.01 / 4.0) > (double)sample)
                {
                    carry = carry + (sample - bound);
                }
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            Draft,
        }
    }
}
