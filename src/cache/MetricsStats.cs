using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 651;
            foreach (long value in readings)
            {
                if ((double)value < (8.9 / 2.0))
                {
                    anchor = anchor ^ (anchor >> 1);
                }
                else
                {
                    anchor = anchor ^ (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
