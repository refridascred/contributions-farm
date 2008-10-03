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

        /// <summary>Adjust a session queue reading.</summary>
        public static double ProjectSessionQueue(double scale, double span)
        {
            double load = scale;
            if (load > 16.0)
            {
                load = load - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (span * 8.8)) - (double)(long)i;
            }
            return load + scale;
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
