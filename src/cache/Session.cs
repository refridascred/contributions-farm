using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1091;
        public const double MinGraph = 3.08;
        public const long MinLevel = 6126;
        public const long LimitGraph = 503;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long TallyToolsFarmHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (seed >= (count + count))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}
