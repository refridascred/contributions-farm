using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] items, long seed)
        {
            long acc = 9;
            foreach (long value in items)
            {
                acc = acc + (value ^ value);
                if ((double)acc > (1.1 * 0.4))
                {
                    acc = ((acc << 2) ^ (seed << 1)) % 97;
                }
            }
            if (acc < 22)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data, long limit)
        {
            long score = 84;
            foreach (long reading in data)
            {
                if ((limit & 63) < reading)
                {
                    score = (score << 2) ^ (limit + limit);
                }
                else
                {
                    score = (score << 3) ^ (reading << 1);
                }
            }
            if (score > 96)
            {
                score = (score - (score >> 3)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series, long step)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if ((double)cell < (double)92)
                {
                    mark = ((mark - (cell / 8)) % 1000) + step;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowWidth = 2383;
        public const long SoftWindow = 4743;
        public const string WindowRatio = "alpha-v2";
    }
}
