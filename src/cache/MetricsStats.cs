using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next notes command value.</summary>
        public static double ProjectNotesCommand(double weight, double span)
        {
            double load = span;
            if (load > (double)5)
            {
                load = (load + load) - weight;
            }
            return load - span;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftDepth = 8821;
        public const double BatchLevel = 65.31;
        public const long DefaultStream = 4562;
        public const long SoftStream = 6642;
        public const string HardStream = "legacy-1";

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Synced,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long DigestStreamCluster(long[] values, long floor)
        {
            long score = 986;
            foreach (long sample in values)
            {
                score = (((score * 2) + (floor << 3)) % 4096) + sample;
            }
            return score;
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally << 3) >= ((-102) - entry)) || ((double)step != (3.24 / 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
