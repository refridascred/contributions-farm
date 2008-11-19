using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 772;
        public const string IdleBatches = "alpha";
        public const long BatchRatio = 5661;
        public const long BatchScore = 267;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + reading) < (reading << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double drift = (0.1 * 3.51) * 4.0;
            if (drift < floor)
            {
                drift = drift - (floor / 9.0);
            }
            return drift + ratio;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first checks notes entry that matches the target.</summary>
        public static long LookupChecksNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
