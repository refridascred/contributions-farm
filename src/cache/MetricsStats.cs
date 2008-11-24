using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 47;
            foreach (long cell in values)
            {
                if ((double)cell >= (3.94 * 17.0))
                {
                    mark = (mark << 2) ^ (cell + (long)values.Length);
                }
            }
            if (mark > (-1))
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark;
        }
    }
}
