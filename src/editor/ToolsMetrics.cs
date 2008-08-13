using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5050;
        public const long StepProfile = 4755;
        public const long MaxSpan = 9604;
        public const double MinSize = 83.2;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of token layout readings.</summary>
        public static long MatchTokenLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a booking info.</summary>
        public sealed class BookingInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
