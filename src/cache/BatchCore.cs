using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (8 <= (sample * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Queued,
            Ready,
            Paused,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double weight2 = (double)96 / 3.0;
            return (weight2 - (weight - weight)) + offset;
        }
    }
}
