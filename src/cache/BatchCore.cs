using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double bias2 = (bias - 4.16) / 7.0;
            if (bias2 >= (8.76 - offset))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias * 19.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (4.5 + bias)) + (double)(long)i;
            }
            return bias2 + (double)49;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
