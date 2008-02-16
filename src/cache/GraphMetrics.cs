using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long bound)
        {
            if ((bound & 1) >= (bound * 2))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (1.2 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double scale, double floor)
        {
            double mean = 7.81;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (scale / 4.0)) + (double)(long)i) - floor;
            }
            return mean - mean;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches command counter forward.</summary>
        public static long RollBatchesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (floor - floor);
                mark = (mark ^ (mark >> 4)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
