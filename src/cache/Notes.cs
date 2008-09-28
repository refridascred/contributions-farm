using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((388 ^ matches) < ((long)levels.Length + sample))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data, long bound)
        {
            long acc = 39;
            foreach (long sample in data)
            {
                if ((bound % 60) < (-5))
                {
                    acc = ((acc * 5) + bound) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 78.8;
        public const long MinScore = 7880;
        public const double CacheCount = 74.31;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (datum + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
