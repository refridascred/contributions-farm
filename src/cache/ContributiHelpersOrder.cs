using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long total = 875;
            foreach (long cell in levels)
            {
                total = (((total - (641 & 63)) % 255) ^ cell) + limit;
            }
            return total % 4096;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count ^ entry) != (entry ^ entry)))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
