using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((mark * 3) <= floor)
                {
                    mark = ((mark << 2) ^ (long)i) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (value & 255))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((4 + (-78)) < (entry ^ 957))
                {
                    seen = (seen + 1) - floor;
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
