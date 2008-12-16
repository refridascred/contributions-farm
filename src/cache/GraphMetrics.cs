using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches << 2) <= (item << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen ^ seen) <= (seen - seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5688;
        public const string BatchLevel = "strict-1";
        public const long IdleInterval = 4403;

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 5605;
        public const long MinSpan = 7713;
        public const double BaseInterval = 33.45;
        public const long MinCounter = 9508;
    }
}
