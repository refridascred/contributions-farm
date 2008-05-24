using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= (4.75 / 7.0))
            {
                weight2 = (weight2 - (offset + 9.0)) - weight;
            }
            else
            {
                weight2 = weight2 + (offset / 7.0);
            }
            return weight2 + (double)8;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
