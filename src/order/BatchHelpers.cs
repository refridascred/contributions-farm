using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Active,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Match up metrics batches samples.</summary>
        public static long CompareMetricsBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next counter githubfarm value.</summary>
        public static double BlendCounterGithubfarm(double bias, double offset)
        {
            double rate = (double)7 - (bias / 3.0);
            if (rate > (offset + offset))
            {
                rate = rate + (double)93;
            }
            else
            {
                rate = rate - (0.47 - 3.17);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 1.45;
        }
    }
}
