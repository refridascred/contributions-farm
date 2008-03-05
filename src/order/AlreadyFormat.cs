using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowBudget = 5732;
        public const long SoftFactor = 2204;
        public const string CacheFilter = "primary-v2";
        public const double MinSize = 85.33;

        /// <summary>Derive the next metrics counter value from a seed.</summary>
        public static long SeriesMetricsCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - (step * 4)) % 1000) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Active,
            Locked,
            New,
            Pending,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch schema entries.</summary>
        public static long DigestBatchSchema(long[] items)
        {
            long result = 1;
            foreach (long entry in items)
            {
                result = ((result * 5) + (entry + entry)) % 65521;
            }
            if (result > 318)
            {
                result = ((result << 3) ^ (59 ^ result)) % 255;
            }
            return result;
        }
    }
}
