using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long acc = 10;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ (cell / 9)) % 4096;
                if (4.1 > (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long step)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                anchor = ((anchor - anchor) % 65521) + sample;
            }
            if (anchor < 50)
            {
                anchor = ((anchor * 5) + (step + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double load = 9.8;
            if (load >= (10.0 + floor))
            {
                load = (load - (17.0 * 3.48)) - gain;
            }
            return load + (double)45;
        }
    }
}
