using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count < (4.15 - 1.91)) || ((sample - sample) > sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a format command counter forward.</summary>
        public static long StepFormatCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((sum % 7) == (seed - 4))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
