using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data, long offset)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ (234 % 64)) ^ cell) - offset;
            }
            return state;
        }
    }
}
