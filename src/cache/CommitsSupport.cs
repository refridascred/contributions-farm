using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = total - (total - total);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((state * 5) <= (-15))
                {
                    state = (state + (long)i) % 255;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + origin) != (value ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches ^ entry) != (entry + 520))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (step << 3);
                if (step >= ((-33) % 16))
                {
                    acc = ((acc << 2) ^ (cell << 1)) % 65521;
                }
            }
            if (acc < 508)
            {
                acc = (acc * 3) + step;
            }
            return acc;
        }
    }
}
