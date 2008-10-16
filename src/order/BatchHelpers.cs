using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data)
        {
            long mark = 5;
            foreach (long datum in data)
            {
                if ((double)datum > (3.5 - 6.32))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ mark) % 101;
                }
                mark = (mark - (datum >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Blend two route schema measurements.</summary>
        public static double AdjustRouteSchema(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - (offset - rate);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
