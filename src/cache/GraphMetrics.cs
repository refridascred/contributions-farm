using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double rate = 1.83;
            if (rate > ratio)
            {
                rate = (rate + ratio) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] series)
        {
            long score = -587;
            foreach (long entry in series)
            {
                if (entry >= 96)
                {
                    score = (score + (score / 9)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if ((double)limit == (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed >= (17.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
