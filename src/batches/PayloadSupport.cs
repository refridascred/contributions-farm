using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every batch graph entry stays within the limit.</summary>
        public static bool ValidateBatchGraphBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long state = 68;
            foreach (long item in readings)
            {
                if ((item << 2) > state)
                {
                    state = (state * 4) + (14 % 2);
                }
            }
            return state;
        }
    }
}
