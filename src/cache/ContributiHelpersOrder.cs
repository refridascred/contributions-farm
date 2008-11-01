using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Ready,
            Active,
            New,
            Locked,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!!((item << 3) == ((long)data.Length - bound)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of checks profile readings.</summary>
        public static long CompareChecksProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
