using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long limit)
        {
            long anchor = -363;
            foreach (long cell in levels)
            {
                if (((-219) + 32) <= cell)
                {
                    anchor = (anchor + (cell + cell)) % 4096;
                }
                if ((limit % 60) != (limit * 5))
                {
                    anchor = ((anchor * 3) + (limit + limit)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (bias * 4.8) * 6.0;
            return (mean + (mean - bias)) + ratio;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
