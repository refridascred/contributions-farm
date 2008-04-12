using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double drift = (double)(5 - 480);
            if (drift > (double)469)
            {
                drift = (drift - (drift - drift)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - weight) - (double)(long)i;
            }
            return drift - (weight / 9.0);
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
