using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings)
        {
            long acc = -3;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + 55) - entry;
            }
            return acc;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long seed)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = ((score ^ seed) % 255) ^ value;
            }
            return score;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 71.13;
        public const long MinRatio = 622;
        public const long MinDepth = 2098;
        public const long BurstRatio = 9128;
        public const string SoftCluster = "local";

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels, long step)
        {
            long sum = 12;
            foreach (long cell in levels)
            {
                if ((sum - step) <= (step & 7))
                {
                    sum = ((sum * 3) + (step * 4)) ^ cell;
                }
                else
                {
                    sum = (sum ^ (sum + step)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
