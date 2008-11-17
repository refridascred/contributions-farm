using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 5566;
        public const string RetryRecord = "local-edge";
        public const double StepDepth = 70.18;
        public const string MinRecord = "strict-edge";
        public const long IdleRecord = 6535;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell * 3) >= cell)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Count batches checks pairs that satisfy a relation.</summary>
        public static long MatchBatchesChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long FoldGraphMetric(long[] data, long step)
        {
            long mix = 10;
            foreach (long datum in data)
            {
                if (!((mix / 7) > (step - step)))
                {
                    mix = ((mix - (step << 2)) % 4096) ^ datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a checks route reading.</summary>
        public static double ScaleChecksRoute(double bias, double bias2)
        {
            double ratio = 8.32;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - bias2) + (double)(long)i) + bias;
            }
            return ratio - (double)71;
        }
    }
}
