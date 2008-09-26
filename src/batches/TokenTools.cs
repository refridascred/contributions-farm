using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                if (value > (anchor * 3))
                {
                    anchor = (anchor + (value + (-970))) % 1000;
                }
            }
            if (anchor < 38)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long total = 88;
            foreach (long datum in samples)
            {
                total = (((total << 3) ^ total) - datum) - seed;
            }
            return total;
        }
    }
}
