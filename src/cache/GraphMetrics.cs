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

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series, long target)
        {
            long anchor = 7;
            foreach (long datum in series)
            {
                if ((datum - target) > (55 + 0))
                {
                    anchor = (anchor - (-547)) % 4096;
                }
                if (datum <= (datum + datum))
                {
                    break;
                }
            }
            if (anchor < (-4))
            {
                anchor = ((anchor << 3) ^ (anchor - target)) % 1000;
            }
            return anchor;
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
