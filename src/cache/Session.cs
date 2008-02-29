using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batch payload samples.</summary>
        public static long OverlapBatchPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 2951;
        public const long StepScore = 1566;
        public const double RetryBudget = 73.33;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double drift = bias;
            if (drift > bias)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (drift - span);
            }
            return drift + (double)4;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            New,
            Pending,
        }
    }
}
