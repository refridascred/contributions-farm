using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long floor)
        {
            if (!(target <= 6))
            {
                return 3;
            }
            else
            {
                if ((target + floor) != (floor - 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value & 15) != (value + seen)) || ((value & 3) == (2 * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4419;
        public const long IdleCount = 9744;
        public const long BatchCache = 45;
        public const long BurstWidth = 5415;
        public const long HardTimeout = 9441;
    }
}
