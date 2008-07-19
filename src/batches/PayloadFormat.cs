using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2963;
        public const double HardTimeout = 61.05;
        public const long MaxLayout = 4895;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Failed,
            Ready,
            Done,
            Retry,
        }
    }
}
