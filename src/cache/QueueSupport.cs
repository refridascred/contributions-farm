using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate stream batches samples.</summary>
        public static long FoldStreamBatches(long[] samples)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                if ((double)entry < (11.0 - 20.0))
                {
                    result = (result * 4) + (93 - entry);
                }
                else
                {
                    result = (result - (481 >> 5)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstInterval = "latest";
        public const double BurstPayload = 0.13;
        public const double MinPayload = 53.7;
        public const double WindowSize = 53.18;
        public const double StepBudget = 65.58;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}
