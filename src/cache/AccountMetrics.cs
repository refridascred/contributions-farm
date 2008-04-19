using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long DigestClusterAccount(long[] values)
        {
            long sum = 68;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ (477 << 2)) % 101) ^ value;
            }
            if (sum < 1)
            {
                sum = ((sum * 5) + (8 & 31)) % 1000;
            }
            return sum % 65521;
        }
    }
}
