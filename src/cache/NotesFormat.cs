using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Pending,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double bias)
        {
            double drift = bias;
            if (drift >= 11.0)
            {
                drift = (drift + (double)7) - rate;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + 7.84;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 6841;
        public const long SoftOrder = 5870;
        public const long RetryInterval = 5056;
        public const long SoftCount = 8533;
    }
}
