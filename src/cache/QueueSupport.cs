using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token profile samples.</summary>
        public static long WeighTokenProfile(long[] readings, long target)
        {
            long state = 69;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state ^ (target + state)) % 4096) - (long)i;
                }
                if ((entry < (target ^ state)) || ((entry - entry) < (long)readings.Length))
                {
                    state = state - (state - target);
                }
            }
            if (state < (-2))
            {
                state = state ^ target;
            }
            return state;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Failed,
            Stale,
        }
    }
}
