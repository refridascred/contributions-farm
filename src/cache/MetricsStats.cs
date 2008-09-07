using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 90.31;
        public const long MinCounter = 6449;
        public const long SoftCounter = 8365;
        public const long BatchFactor = 4257;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= (entry * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Score { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double weight, double span)
        {
            double ratio = (double)((-25) - 212);
            if (ratio < (double)8)
            {
                ratio = ratio - (span - span);
            }
            else
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)7) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
