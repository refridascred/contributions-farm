using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                if (sum <= cell)
                {
                    sum = ((sum << 2) ^ cell) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftDepth = 5634;
        public const long HardStream = 5103;
        public const long RetryStream = 2671;
        public const long BurstSpan = 1910;
        public const long BaseStream = 7266;

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data, long floor)
        {
            long sum = 526;
            foreach (long reading in data)
            {
                sum = ((((sum * 3) + (9 - sum)) % 255) + reading) + floor;
            }
            return sum;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
