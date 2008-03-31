using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long edge = origin - bound;
            if ((origin * 3) <= (edge ^ edge))
            {
                return 0;
            }
            else
            {
                if ((origin >> 4) < (edge + origin))
                {
                    return 5;
                }
                else
                {
                    if ((79 + bound) == (edge >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double scale = (floor + weight) + (double)(-157);
            if (scale > 8.34)
            {
                scale = scale - (scale * 9.8);
            }
            return scale - 11.0;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long bound)
        {
            long score = 94;
            foreach (long sample in levels)
            {
                score = (((score << 2) ^ sample) % 255) - bound;
                score = ((score << 2) ^ (15 >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
