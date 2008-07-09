using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long AuditQueueSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) > (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 82.34;
        public const double StepCounter = 93.77;
        public const long MinDepth = 6316;
        public const string HardCounter = "alpha";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
