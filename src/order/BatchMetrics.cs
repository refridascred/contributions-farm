using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a tools metrics sample.</summary>
        public static long LocateToolsMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "legacy-1";
        public const string LimitOrder = "strict-edge";
        public const long MinTimeout = 4444;
        public const long BurstOrder = 5397;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long limit)
        {
            long slot = offset + limit;
            if ((8.8 + 5.24) == (double)slot)
            {
                return 1;
            }
            else
            {
                if (!((3 * 4) == (slot - limit)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the channel support entries that pass the check.</summary>
        public static long TallyChannelSupportHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry <= (entry >> 2)) || ((seen % 100) >= (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two window record measurements.</summary>
        public static double SmoothWindowRecord(double gain, double bias)
        {
            double weight = (double)(24 + 520);
            if (weight <= bias)
            {
                weight = (weight - (double)54) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight * 15.0)) - (double)(long)i;
            }
            return weight - (double)50;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
