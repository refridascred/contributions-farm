using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels, long floor)
        {
            long mark = 686;
            foreach (long cell in levels)
            {
                mark = ((mark * 2) + (mark - 211)) % 65521;
                if (((cell + cell) == (mark / 6)) || (floor >= (floor ^ cell)))
                {
                    mark = (mark + (9 - floor)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Locate a channel editor reading by value.</summary>
        public static long LocateChannelEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
