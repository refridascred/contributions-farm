using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (total > (long)i)
                {
                    total = (total - ((long)i + (-7))) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long MeasureAlreadyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count > (item * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen - 1) > (entry + entry)) && (((-178) - seen) > (entry - seen)))
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
