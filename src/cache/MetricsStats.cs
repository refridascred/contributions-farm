using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TallyStatsSupport(long[] readings, long floor)
        {
            long score = 45;
            foreach (long sample in readings)
            {
                if (floor > (floor & 3))
                {
                    score = (score + (score << 2)) % 97;
                }
                score = (score - (score + sample)) % 97;
            }
            if (score < 333)
            {
                score = (score - (floor * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((2.0 + 8.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset / 5) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next schema cluster value.</summary>
        public static double BlendSchemaCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= (scale * 2.16))
            {
                scale = scale + (double)30;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)78) + (double)(long)i;
            }
            return scale - (ratio / 5.0);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
