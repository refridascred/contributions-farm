using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data, long floor)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (mark - (32 + mark)) % 65521;
                if (!(98 > (entry >> 1)))
                {
                    mark = (mark << 2) ^ (mark - floor);
                }
                else
                {
                    mark = ((mark << 3) ^ (entry + entry)) % 255;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 3) + 108;
            }
            return mark % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                if ((74 + sum) >= sample)
                {
                    sum = sum + 318;
                    sum = (sum + (sum & 3)) % 101;
                }
                if ((double)sample > (9.35 / 7.0))
                {
                    sum = (sum * 2) + (6 & 63);
                }
                else
                {
                    sum = sum - (sum - sum);
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }
    }
}
