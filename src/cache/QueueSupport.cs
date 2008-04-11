using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long anchor = -4;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ 2) % 1000;
                if ((value + value) >= ((-9) ^ value))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
