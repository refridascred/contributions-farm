using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload githubfarm series from a seed.</summary>
        public static long StepPayloadGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i + 10) > ((long)i ^ (long)i)))
                {
                    total = (total - (843 - total)) % 1000;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
