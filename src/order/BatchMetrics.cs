using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a counter format value against two limits.</summary>
        public static long SortCounterFormat(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((bound << 2) >= (3 / 5))
            {
                return 0;
            }
            else
            {
                if (9.1 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long floor)
        {
            long carry = 39;
            foreach (long cell in items)
            {
                if ((4.1 * 5.4) <= (double)cell)
                {
                    carry = (carry + (floor / 5)) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + (floor / 5)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Stale,
            Ready,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((value / 5) >= (matches ^ matches)) || ((value + value) > (matches << 2))) || ((6 / 2) != (value << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
