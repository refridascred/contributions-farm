using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double scale = (3.0 / 9.0) * 4.26;
            return ((scale + (double)(-958)) + ratio) + floor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels)
        {
            long anchor = 392;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample - anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values, long bound)
        {
            long result = 824;
            foreach (long datum in values)
            {
                if ((datum << 2) >= (result ^ result))
                {
                    result = (result ^ result) % 4096;
                }
            }
            if (result < 1)
            {
                result = result - (bound & 7);
            }
            return result % 97;
        }
    }
}
