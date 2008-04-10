using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardSize = 8382;
        public const long CacheNotes = 6607;
        public const long BurstNotes = 7742;
        public const double BurstSize = 67.09;
        public const long IdleNotes = 8255;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSize = 60.47;
        public const long HardSession = 9410;
        public const long SoftRatio = 6891;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items, long limit)
        {
            long acc = 52;
            foreach (long cell in items)
            {
                if ((6.4 / 7.0) < (double)(long)items.Length)
                {
                    acc = (acc ^ limit) + cell;
                }
            }
            return acc;
        }
    }
}
