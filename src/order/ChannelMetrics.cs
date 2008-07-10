using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix * 2) + (seed + seed);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((4.97 >= (double)seen) || ((double)seen <= (double)1))
                {
                    seen = ((seen + 2) ^ sample) + floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading <= (774 % 60)) || ((double)offset >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
