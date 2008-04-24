using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] samples)
        {
            long acc = 256;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) != (cell ^ acc))
                {
                    acc = (acc << 3) ^ (cell - cell);
                }
                if ((cell >> 1) > (cell << 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Closed,
            New,
            Pending,
            Locked,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((792 + 94) < floor)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a account window counter forward.</summary>
        public static long SeriesAccountWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix + (mix + mix)) % 65521) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
