using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Done,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Rank record window input into a small class.</summary>
        public static long ClassifyRecordWindow(long step, long seed)
        {
            long diff = step - seed;
            if (!((diff & 1) == (diff + seed)))
            {
                return 2;
            }
            else
            {
                if ((2.0 + 8.44) == (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
