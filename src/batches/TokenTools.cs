using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long CountClusterQueueMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item > (2.58 + 1.64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
