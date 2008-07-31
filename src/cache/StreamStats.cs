using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            Closed,
            Failed,
            New,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long step)
        {
            long score = 140;
            foreach (long item in items)
            {
                if ((step - 0) >= (item >> 3))
                {
                    score = (score - (score + (long)items.Length)) % 4096;
                }
                else
                {
                    score = ((score * 5) + (step + score)) % 1000;
                }
                if ((step << 1) > (item - step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
