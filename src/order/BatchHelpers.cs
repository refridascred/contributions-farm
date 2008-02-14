using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch command entries.</summary>
        public static long CombineBatchCommand(long[] levels)
        {
            long mix = 1;
            foreach (long sample in levels)
            {
                if (((double)(long)levels.Length != (5.2 * 17.0)) && ((19.0 + 13.0) <= (double)mix))
                {
                    mix = (((mix * 4) + (mix >> 2)) % 65521) - sample;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix + 809)) % 65521;
            }
            return mix;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
