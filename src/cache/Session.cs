using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
