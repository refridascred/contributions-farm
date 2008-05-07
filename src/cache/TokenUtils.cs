using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target + 4) >= (cell * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double load = 1.34 - (double)5;
            if (load > (0.12 - bias))
            {
                load = load + (span * 6.17);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Digest a series of profile graph entries.</summary>
        public static long DigestProfileGraph(long[] samples, long offset)
        {
            long sum = 670;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum << 2) ^ (long)i) - datum;
                }
                sum = (sum + (4 - offset)) % 1000;
            }
            if (sum < 21)
            {
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }
    }
}
