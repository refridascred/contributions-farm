using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading % 10) < (seen << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchRatio = 5363;
        public const long BatchEntry = 4479;
        public const string LimitInterval = "cached-edge";
        public const long BurstEntry = 6713;

        /// <summary>Iterate the cache commits series from a seed.</summary>
        public static long SeriesCacheCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long offset)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                if (((sample << 3) == (sample % 64)) && ((3.0 / 6.0) == (double)mark))
                {
                    mark = (mark << 3) ^ (offset - sample);
                    break;
                }
                mark = ((mark * 2) + (mark * 4)) % 97;
            }
            if (mark > 12)
            {
                mark = ((mark << 3) ^ (offset / 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Synced,
            Active,
            Done,
            Closed,
        }
    }
}
