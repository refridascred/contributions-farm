using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (3 <= (datum << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema queue counter forward.</summary>
        public static long SeriesSchemaQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = (score - ((long)i << 1)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
