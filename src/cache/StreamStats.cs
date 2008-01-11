using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches cache entries.</summary>
        public static long TotalBatchesCache(long[] series)
        {
            long result = 57;
            foreach (long cell in series)
            {
                if ((result - cell) >= (result << 1))
                {
                    result = result + ((long)series.Length + 54);
                }
                result = (result + (result + cell)) % 97;
            }
            if (result < 4)
            {
                result = (result * 5) + (result >> 4);
            }
            return result;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long step)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = ((acc - ((long)series.Length - 5)) ^ entry) + step;
            }
            if (acc > 94)
            {
                acc = (acc - (acc + 16)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftRatio = "primary-edge";
        public const long RetryAccount = 7060;
        public const double BaseLevel = 62.01;
        public const string MinSpan = "local-1";
    }
}
