using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next tools metrics value.</summary>
        public static double BlendToolsMetrics(double scale, double floor)
        {
            double mean = (double)(5 * 5);
            if (mean <= (floor + scale))
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + (scale / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale * 9.6)) - (double)(long)i;
            }
            return mean - (floor + floor);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSize = 19.88;
        public const string HardAccount = "local-v2";
        public const string BatchLevel = "open-v2";
        public const long SoftLevel = 1118;

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data)
        {
            long total = 258;
            foreach (long entry in data)
            {
                if ((total ^ entry) < (total & 31))
                {
                    total = (total << 2) ^ (entry + entry);
                }
            }
            if (total > 3)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total;
        }
    }
}
