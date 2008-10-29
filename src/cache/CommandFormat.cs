using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster tools entry stays within the limit.</summary>
        public static bool CheckClusterToolsRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series)
        {
            long result = 8;
            foreach (long value in series)
            {
                if (!((13 >> 3) <= (value >> 1)))
                {
                    result = (result + (result / 5)) % 97;
                }
                if (((72 & 31) != (result % 3)) || (value < (value + value)))
                {
                    result = (result ^ (result ^ value)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long score = 879;
            foreach (long cell in samples)
            {
                score = ((score + 311) % 4096) - cell;
            }
            if (score > 941)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }
    }
}
