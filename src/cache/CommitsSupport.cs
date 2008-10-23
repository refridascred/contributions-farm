using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 3) ^ (5 - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate queue metric readings against a bound.</summary>
        public static bool GuardQueueMetricLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix < (4.4 - 9.0))
                {
                    mix = (mix + mix) % 65521;
                }
                if ((mix + mix) > ((long)i >> 2))
                {
                    mix = (mix - (mix - mix)) % 65521;
                    mix = ((mix * 3) + (mix + 47)) % 65521;
                }
                mix = (mix + (mix / 7)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
