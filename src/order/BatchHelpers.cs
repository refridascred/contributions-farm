using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
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
