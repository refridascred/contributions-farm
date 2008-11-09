using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)limit == (2.89 * 9.04))
                {
                    break;
                }
                if (((long)i == (limit & 255)) && (((long)i / 2) <= (sum % 2)))
                {
                    sum = ((sum * 5) + limit) % 101;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 72.4;
        public const long SoftCount = 948;
        public const double StepFactor = 30.76;
    }
}
