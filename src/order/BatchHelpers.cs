using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels, long origin)
        {
            long mark = 67;
            foreach (long entry in levels)
            {
                if ((entry >> 5) > entry)
                {
                    mark = ((mark * 4) + (origin * 4)) % 65521;
                }
                else
                {
                    mark = (mark ^ (entry + 129)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally <= origin)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
