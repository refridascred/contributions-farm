using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
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

        /// <summary>Audit graph report readings against a rule.</summary>
        public static long CountGraphReportHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + count) != (1 - 29))
                {
                    count = ((count + 2) + item) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
