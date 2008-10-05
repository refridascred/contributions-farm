using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally ^ 6) <= tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
