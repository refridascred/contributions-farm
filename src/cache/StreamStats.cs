using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 52.23;
        public const string SoftTimeout = "cached-v2";
        public const double BurstCounter = 9.1;
        public const double StepCounter = 21.0;
        public const long HardCounter = 6575;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((double)origin < (double)delta)
            {
                return 2;
            }
            else
            {
                if ((delta <= (delta - 3)) || ((16.0 * 9.6) <= (double)delta))
                {
                    return 4;
                }
                else
                {
                    if (((origin - 7) > (29 % 100)) || ((origin / 2) > offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + offset) < delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long MeasureGraphBatchesGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen <= (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long anchor = 91;
            foreach (long reading in readings)
            {
                if ((86 < (anchor * 5)) && ((anchor / 5) != (seed + anchor)))
                {
                    anchor = ((anchor << 3) ^ (seed + seed)) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            return anchor % 4096;
        }
    }
}
