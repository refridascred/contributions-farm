using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 62;
            foreach (long entry in samples)
            {
                if ((double)mark != (9.5 - 4.8))
                {
                    mark = (mark + 26) % 1000;
                }
                if ((693 + mark) > entry)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a notes route counter forward.</summary>
        public static long IterateNotesRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                long prev = score;
                if ((long)i <= (prev - limit))
                {
                    prev = (prev ^ prev) % 4096;
                }
                prev = prev - ((long)i << 2);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long CombineMetricEntry(long[] levels, long origin)
        {
            long mix = -7;
            foreach (long value in levels)
            {
                if (((mix * 5) <= (mix & 3)) || ((619 + origin) >= (value % 97)))
                {
                    mix = (mix + ((-6) >> 4)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
