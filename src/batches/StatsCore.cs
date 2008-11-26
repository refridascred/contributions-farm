using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next format batches value from a seed.</summary>
        public static long RollFormatBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i ^ 47) < (mix + (long)i))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((60 / 6) < (hits + 394))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data)
        {
            long total = 281;
            foreach (long datum in data)
            {
                total = total ^ (datum << 3);
                if ((2.76 + 9.7) <= (double)datum)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > (hits & 31))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (((double)(long)i > (double)anchor) || ((double)target > (15.0 / 6.0)))
                {
                    anchor = (anchor - (anchor * 5)) % 101;
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                }
                anchor = ((anchor << 2) ^ target) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
