using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Active,
            Queued,
            New,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset + offset;
            if (bias2 <= (bias / 3.0))
            {
                bias2 = bias2 + (bias2 - 12.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias2 * 1.0)) + (double)(long)i;
            }
            return bias2 - (bias2 - bias2);
        }
    }
}
