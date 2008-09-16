using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public bool Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a token stats sample.</summary>
        public static long FindTokenStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter batches samples.</summary>
        public static long CombineCounterBatches(long[] samples, long floor)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                if ((floor >> 4) <= floor)
                {
                    score = (score * 5) + (reading * 2);
                }
                if ((long)samples.Length < (floor % 7))
                {
                    score = (score * 2) + (840 ^ reading);
                }
            }
            if (score < 1)
            {
                score = (score + (score * 2)) % 4096;
            }
            return score;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
