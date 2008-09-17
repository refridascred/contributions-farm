using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long state = 40;
            foreach (long value in data)
            {
                if ((3.2 - 5.84) <= (double)seed)
                {
                    state = state - (79 + seed);
                    break;
                }
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - state) % 101) ^ (long)i;
                }
                if ((seed >> 3) < state)
                {
                    state = ((state << 3) ^ (value + seed)) % 65521;
                }
                else
                {
                    state = state ^ (-61);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Iterate the session checks series from a seed.</summary>
        public static long SeriesSessionChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result - step;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
