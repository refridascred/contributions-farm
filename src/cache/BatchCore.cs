using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a schema metrics reading.</summary>
        public static double SmoothSchemaMetrics(double weight, double floor)
        {
            double scale = (double)(229 << 1);
            if (scale > (2.0 * 6.7))
            {
                scale = (scale + (weight * 14.0)) + floor;
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale + (double)78;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 2986;
        public const string IdleCommits = "local-v2";
        public const string LimitCommits = "latest-1";
        public const long CacheCommits = 8390;
        public const double BaseWidth = 97.07;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((5.1 + 9.0) != (double)floor) || ((floor / 5) != (floor - floor)))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long result = 36;
            foreach (long reading in data)
            {
                if ((reading >> 3) >= (result - result))
                {
                    result = (result + ((long)data.Length / 3)) % 65521;
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 254)
            {
                result = ((result << 3) ^ (result + 6)) % 255;
            }
            return result % 1000;
        }
    }
}
