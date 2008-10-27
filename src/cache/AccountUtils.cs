using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of entry batch readings.</summary>
        public static long PairEntryBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long bound)
        {
            long mix = 1;
            foreach (long cell in data)
            {
                mix = ((mix * 2) + (bound ^ cell)) % 1000;
            }
            if (mix > 212)
            {
                mix = mix - (89 & 127);
            }
            return mix % 1000;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            New,
            Draft,
            Closed,
            Locked,
        }
    }
}
