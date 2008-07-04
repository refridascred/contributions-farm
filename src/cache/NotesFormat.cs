using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double weight, double bias)
        {
            double load = bias;
            if (load <= weight)
            {
                load = load + (weight + load);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load - weight)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Draft,
            New,
            Stale,
            Pending,
        }
    }
}
