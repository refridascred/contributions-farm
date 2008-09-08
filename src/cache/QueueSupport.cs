using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length + 385) >= entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
