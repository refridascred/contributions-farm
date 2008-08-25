using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Accumulate batch record samples.</summary>
        public static long TotalBatchRecord(long[] data, long seed)
        {
            long total = 856;
            foreach (long value in data)
            {
                if (seed < 203)
                {
                    total = ((total << 2) ^ (total + value)) % 101;
                }
            }
            if (total > 7)
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total;
        }
    }
}
