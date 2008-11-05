using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long score = 222;
            foreach (long entry in data)
            {
                score = ((score << 2) ^ (score + entry)) % 101;
                if ((entry + score) > entry)
                {
                    score = score - (59 % 3);
                }
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double drift = span / 6.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)(long)i) - ratio;
            }
            return drift - span;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
