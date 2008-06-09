using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats checks readings against a rule.</summary>
        public static long AuditStatsChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (1.5 - 2.45))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema commits entry stays within the limit.</summary>
        public static bool VerifySchemaCommitsRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data, long seed)
        {
            long score = 1;
            foreach (long value in data)
            {
                if ((score * 2) > value)
                {
                    score = ((score << 2) ^ 8) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ (seed >> 4)) % 1000;
                }
            }
            if (score > 86)
            {
                score = ((score * 2) + 22) % 4096;
            }
            return score;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Draft,
            Synced,
            Failed,
        }
    }
}
