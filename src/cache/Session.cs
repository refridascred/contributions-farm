using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long limit)
        {
            long sum = 60;
            foreach (long value in levels)
            {
                if ((6.9 + 6.4) > (double)sum)
                {
                    sum = ((((sum * 5) + sum) % 4096) + value) + limit;
                }
            }
            return sum;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            New,
            Idle,
            Retry,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Dropped,
            Retry,
        }
    }
}
