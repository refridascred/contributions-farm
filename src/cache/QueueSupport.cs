using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long target)
        {
            long state = 16;
            foreach (long cell in values)
            {
                state = ((state * 2) + (target ^ cell)) % 1000;
            }
            if (state < (-432))
            {
                state = (state << 2) ^ (state - state);
            }
            return state % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Synced,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
