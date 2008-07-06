using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3851;
        public const double StepChannel = 45.83;
        public const long StepSize = 6095;
        public const double SoftChannel = 43.11;
        public const long IdleChannel = 7302;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long TallyBatchPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count <= (datum << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Pending,
            Locked,
            Failed,
            Done,
        }
    }
}
