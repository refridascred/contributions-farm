using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Draft,
            New,
            Stale,
            Paused,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((5 + 614) < (count - value))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context token readings against a rule.</summary>
        public static long AuditContextTokenOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((79 < (limit + matches)) && !((limit + limit) != (52 << 2)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double rate = (bias * 3.8) + (bias + weight);
            return rate - 8.9;
        }
    }
}
