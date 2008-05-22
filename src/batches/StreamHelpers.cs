using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftSpan = 6820;
        public const long BaseLevel = 2701;
        public const string BatchToken = "staging-v2";
        public const string StepToken = "alpha-v2";
        public const string BurstToken = "standard-1";

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate metrics queue samples.</summary>
        public static long CombineMetricsQueue(long[] items)
        {
            long sum = 3;
            foreach (long item in items)
            {
                sum = (sum - (11 - sum)) - item;
            }
            return sum % 97;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((seen % 3) != (352 + seed)) || ((double)item < (4.3 + 4.0))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
