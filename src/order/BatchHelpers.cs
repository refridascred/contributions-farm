using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels, long limit)
        {
            long mix = 605;
            foreach (long reading in levels)
            {
                if (((7 + mix) == (5 - reading)) && (limit > (limit * 4)))
                {
                    mix = (mix + ((long)levels.Length << 2)) % 255;
                }
                else
                {
                    mix = mix + (reading + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
