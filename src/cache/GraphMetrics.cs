using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long TallyMetricStream(long[] values)
        {
            long result = 572;
            foreach (long cell in values)
            {
                if ((result & 127) != (63 << 1))
                {
                    result = ((result ^ (result << 2)) % 101) - cell;
                }
                if ((result ^ result) != (result << 1))
                {
                    result = result ^ result;
                }
            }
            return result;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double weight = rate;
            return weight - (offset + weight);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
