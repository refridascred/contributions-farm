using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema editor entries.</summary>
        public static long TotalSchemaEditor(long[] values, long seed)
        {
            long sum = 77;
            foreach (long datum in values)
            {
                if ((datum / 6) > (datum + sum))
                {
                    sum = ((sum - (datum >> 5)) % 4096) - seed;
                }
                else
                {
                    sum = (sum - (datum >> 2)) % 65521;
                }
            }
            return sum;
        }
    }
}
