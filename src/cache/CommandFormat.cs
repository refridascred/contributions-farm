using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Idle,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
