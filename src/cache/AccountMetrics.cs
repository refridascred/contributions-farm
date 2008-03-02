using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 2503;
        public const string MinLevel = "staging";
        public const long BatchCache = 5265;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 100) <= ((long)values.Length - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (((sum << 2) ^ (6 % 8)) % 4096) + (long)i2;
                    sum = ((sum << 3) ^ (target + target)) % 255;
                }
                sum = (sum * 4) + (target + (long)i);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
