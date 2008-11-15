using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long AuditSupportSchemaMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (340 << 1))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long carry = 574;
            foreach (long sample in items)
            {
                if ((((-271) + sample) <= sample) && ((sample ^ carry) > carry))
                {
                    carry = (carry + (long)items.Length) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Iterate the graph stats series from a seed.</summary>
        public static long RollGraphStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ (state + origin)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
