using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long seed)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if (!((state << 3) > (77 / 4)))
                {
                    state = (((state * 3) + item) % 4096) - seed;
                }
            }
            return state;
        }
    }
}
