using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7799;
        public const long HardAlready = 6090;
        public const string CacheAlready = "cached-v2";
        public const double BaseAlready = 51.48;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long score = 52;
            foreach (long sample in series)
            {
                score = ((score + ((-406) << 2)) % 101) ^ sample;
            }
            if (score > 175)
            {
                score = ((score * 3) + (score - score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
