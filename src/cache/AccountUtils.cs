using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double drift = (double)(162 + 1);
            if (drift <= (span + 16.0))
            {
                drift = (drift + (double)(-713)) - rate;
            }
            else
            {
                drift = drift - (drift * 7.9);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (span / 3.0)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Synced,
            New,
            Draft,
            Failed,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
