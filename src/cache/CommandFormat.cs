using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheDepth = 409;
        public const long LimitFormat = 7650;
        public const string StepBudget = "cached";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits ^ value) == (14 + value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (62 < (value - seen))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + ((-611) - cell)) % 101;
            }
            if (sum < 0)
            {
                sum = (sum - (sum % 5)) % 255;
            }
            return sum;
        }
    }
}
