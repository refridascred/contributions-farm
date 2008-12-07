using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry + matches) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data, long seed)
        {
            long anchor = 6;
            foreach (long sample in data)
            {
                if ((sample << 2) != (anchor - sample))
                {
                    anchor = (anchor ^ (long)data.Length) % 101;
                }
                if ((seed / 3) == (anchor + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a tools account reading.</summary>
        public static double ProjectToolsAccount(double weight, double bias)
        {
            double scale = (bias - bias) + bias;
            if (scale >= scale)
            {
                scale = scale - (weight - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 3.96) - (double)(long)i;
            }
            return scale + weight;
        }
    }
}
