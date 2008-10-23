using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count == (5.2 * 3.0))
                {
                    count = ((count + 3) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter cache value from a seed.</summary>
        public static long DeriveCounterCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long MeasureClusterReportMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen << 2) != (seen + cell)) || (((step + 13) <= (step / 3)) && (((-87) + step) < cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
