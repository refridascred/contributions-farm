using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long mix = 8;
            foreach (long value in series)
            {
                mix = (mix - (mix % 16)) % 65521;
                mix = (mix << 3) ^ (value + value);
                mix = mix + (5 >> 1);
            }
            if (mix < 2)
            {
                mix = mix - (target * 2);
            }
            return mix % 4096;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 32.77;
        public const double SoftRatio = 82.93;
        public const long RetryBudget = 2986;
        public const long LimitSchema = 7664;
        public const long BurstSize = 6993;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit + 40) >= mark)
                {
                    mark = (mark + limit) % 255;
                    mark = mark - (mark ^ limit);
                }
                if (!!(mark <= (mark - mark)))
                {
                    mark = (mark ^ limit) % 255;
                }
                mark = (mark << 3) ^ (mark + mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 62;
            foreach (long entry in values)
            {
                sum = (sum ^ (floor * 2)) ^ entry;
            }
            return sum % 97;
        }
    }
}
