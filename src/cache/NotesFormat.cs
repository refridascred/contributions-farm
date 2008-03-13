using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels, long target)
        {
            long acc = -63;
            foreach (long datum in levels)
            {
                acc = ((acc * 5) + (datum ^ acc)) % 255;
                if (datum >= (datum - 8))
                {
                    acc = ((acc << 2) ^ (target * 3)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
