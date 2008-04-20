using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values)
        {
            long score = 29;
            foreach (long entry in values)
            {
                if ((score * 5) > (long)values.Length)
                {
                    score = (score + score) + entry;
                }
            }
            if (score < 65)
            {
                score = ((score << 3) ^ (score << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series, long seed)
        {
            long mark = 49;
            foreach (long cell in series)
            {
                if ((seed - seed) <= (cell * 5))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = 0.4;
            return (rate - floor) + weight;
        }
    }
}
