using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 5814;
        public const long StepCount = 9186;
        public const string RetrySize = "standard-v2";

        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long MeasureCounterLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count <= (44 << 3)) || (count <= (entry & 15)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
