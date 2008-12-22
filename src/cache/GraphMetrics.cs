using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
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
