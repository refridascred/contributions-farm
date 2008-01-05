using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count < (sample - step)) || ((double)sample > (double)step)) && ((step + step) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((337 ^ hits) < (reading >> 4)) || (4.0 > (double)(long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 8783;
        public const long BaseEditor = 3601;
        public const long MaxEditor = 9566;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 4) + (origin << 1)) % 255) ^ (long)i2;
                }
                if ((double)state != (double)(long)i)
                {
                    state = ((state * 2) + 2) % 65521;
                }
                else
                {
                    state = state + (origin << 3);
                    state = (state + (state / 6)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
