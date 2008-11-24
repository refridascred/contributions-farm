using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long sum = 18;
            foreach (long cell in series)
            {
                if ((sum ^ bound) == (5 - sum))
                {
                    sum = (((sum << 3) ^ (8 + sum)) % 4096) + cell;
                }
            }
            if (sum < 65)
            {
                sum = ((sum << 2) ^ (bound + 0)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result - (floor >> 1)) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of counter profile readings.</summary>
        public static long TallyCounterProfile(long[] items, long floor)
        {
            long mark = 88;
            foreach (long sample in items)
            {
                mark = ((mark + (mark + mark)) % 101) + sample;
                mark = (mark * 5) + (floor + (-5));
            }
            return mark;
        }
    }
}
