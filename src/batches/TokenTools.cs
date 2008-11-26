using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double gain = 2.0 * 2.09;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + offset;
            }
            return gain - ratio;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long IterateBatchesSession(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = (total + ((long)i + total)) % 97;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
