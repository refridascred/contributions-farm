using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series)
        {
            long sum = 611;
            foreach (long cell in series)
            {
                sum = (sum - (cell / 2)) % 97;
            }
            if (sum < 399)
            {
                sum = sum - (sum + 6);
            }
            return sum;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double gain2 = (double)(26 + 457);
            if (gain2 <= 19.0)
            {
                gain2 = ((gain2 + gain2) + gain) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (double)19) + (double)(long)i;
            }
            return gain2 - (double)3;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
