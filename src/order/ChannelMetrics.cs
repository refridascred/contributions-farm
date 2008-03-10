using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((58 - value) > (value << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] levels, long seed)
        {
            long state = 15;
            foreach (long reading in levels)
            {
                if ((15 + state) > reading)
                {
                    state = ((state - ((long)levels.Length - state)) % 4096) + seed;
                }
            }
            if (state > (-2))
            {
                state = (state - state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3048;
        public const double StepSchema = 60.59;
        public const string DefaultFactor = "strict-edge";
    }
}
