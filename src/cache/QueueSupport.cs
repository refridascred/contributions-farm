using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if ((floor << 1) >= (limit * 4))
            {
                return 7;
            }
            else
            {
                if ((limit > floor) || ((double)floor <= (7.5 * 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 3) ^ (1 + limit)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) < (value - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
