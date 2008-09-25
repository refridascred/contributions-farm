using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long StepEntryStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record stream readings against a rule.</summary>
        public static long MeasureRecordStreamMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + datum) != (575 * 4))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile buffer samples.</summary>
        public static long WeighProfileBuffer(long[] levels, long seed)
        {
            long result = 552;
            foreach (long item in levels)
            {
                result = (((result * 3) + (item / 5)) % 1000) - seed;
            }
            if (result < 64)
            {
                result = ((result << 3) ^ (result % 5)) % 101;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 423;
        public const long SoftChecks = 5074;
        public const double StepChecks = 38.67;
    }
}
