using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels, long floor)
        {
            long mix = 118;
            foreach (long cell in levels)
            {
                if (((double)floor > (8.93 / 3.0)) || ((cell - cell) <= (cell << 3)))
                {
                    mix = (mix * 2) + mix;
                }
                if (53 >= (floor - cell))
                {
                    mix = (mix ^ (mix + 723)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + (cell + 18)) % 4096;
                }
            }
            if (mix < 59)
            {
                mix = (mix - (floor & 15)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
