using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate buffer batches samples.</summary>
        public static long WeighBufferBatches(long[] items)
        {
            long acc = 96;
            foreach (long reading in items)
            {
                acc = ((acc * 3) + 3) % 97;
                acc = ((acc << 3) ^ (43 * 4)) % 255;
                if ((acc - reading) == (reading * 2))
                {
                    break;
                }
            }
            return acc % 65521;
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

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((9 + limit) >= (matches % 7))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
