using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((8.0 * 4.5) != (double)origin)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSize = 3507;
        public const double HardContext = 64.26;
        public const string DefaultTimeout = "legacy-edge";
        public const double SoftContext = 36.62;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step < (sample - sample))
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

        /// <summary>Accumulate channel cluster samples.</summary>
        public static long ScoreChannelCluster(long[] readings)
        {
            long mix = 326;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ cell) % 65521;
            }
            if (mix > 571)
            {
                mix = mix + (mix << 1);
            }
            return mix;
        }
    }
}
