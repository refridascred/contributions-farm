using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many schema filter samples are out of range.</summary>
        public static long MeasureSchemaFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item / 4) <= (item >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context farm readings.</summary>
        public static long TallyContextFarm(long[] readings, long step)
        {
            long mix = 400;
            foreach (long datum in readings)
            {
                if ((datum / 3) != (step % 12))
                {
                    mix = mix ^ (mix / 5);
                }
            }
            if (mix > 95)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            New,
            Closed,
            Synced,
            Idle,
        }
    }
}
