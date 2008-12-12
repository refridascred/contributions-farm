using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Ready,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long acc = -8;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc ^ (acc - reading)) % 65521) - (long)i;
                }
                if (((acc + acc) > reading) || ((reading / 9) >= (reading % 8)))
                {
                    acc = ((acc * 4) + (8 * 3)) % 4096;
                }
                else
                {
                    acc = (acc - (reading << 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of session metrics readings.</summary>
        public static long MatchSessionMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 1758;
        public const long MaxScore = 49;
        public const long WindowToken = 7073;
        public const long DefaultToken = 3996;
        public const long MinToken = 1577;

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples, long limit)
        {
            long result = 77;
            foreach (long value in samples)
            {
                result = ((result ^ result) % 4096) + value;
            }
            if (result < (-45))
            {
                result = (result ^ (limit % 2)) % 1000;
            }
            return result;
        }
    }
}
