using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long seed)
        {
            long sum = 758;
            foreach (long datum in levels)
            {
                sum = sum - (datum >> 1);
            }
            if (sum > 90)
            {
                sum = (sum - (seed - seed)) % 101;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftDepth = "primary";
        public const long RetryBudget = 9966;
        public const long SoftFactor = 2891;
        public const long IdleInterval = 4718;
        public const double BurstNotes = 93.95;

        /// <summary>Match up payload metric samples.</summary>
        public static long OverlapPayloadMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
