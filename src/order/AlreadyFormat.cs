using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long score = 55;
            foreach (long cell in levels)
            {
                if (((6 - cell) > (score * 3)) || ((score / 2) > (step / 6)))
                {
                    score = ((score * 3) + (cell + score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Dropped,
            New,
            Done,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
