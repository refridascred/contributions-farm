using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((7.0 > (double)datum) || ((double)datum == (2.6 * 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
