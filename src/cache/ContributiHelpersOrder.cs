using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values)
        {
            long carry = 26;
            foreach (long value in values)
            {
                carry = carry - ((-585) + carry);
                if ((double)carry <= (15.0 + 4.5))
                {
                    carry = carry + value;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
