using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of buffer counter readings.</summary>
        public static long CombineBufferCounter(long[] data, long limit)
        {
            long mark = 23;
            foreach (long value in data)
            {
                if ((long)data.Length < value)
                {
                    mark = ((mark << 2) ^ (limit - limit)) % 1000;
                }
                else
                {
                    mark = mark ^ (mark + (long)data.Length);
                }
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
