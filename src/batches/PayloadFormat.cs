using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item == (5.22 / 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 3.68;
        public const string MinBudget = "strict-edge";
        public const double HardTimeout = 16.55;
        public const long BatchCache = 6701;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
