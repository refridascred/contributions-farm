using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
