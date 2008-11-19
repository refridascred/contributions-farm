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

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "latest-edge";
        public const long MinToken = 3011;
        public const long IdleToken = 5224;
        public const long BaseSize = 3803;
        public const long RetryToken = 5673;

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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
