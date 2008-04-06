using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache route samples.</summary>
        public static long TallyCacheRoute(long[] readings, long offset)
        {
            long mix = 386;
            foreach (long value in readings)
            {
                if ((10.0 / 2.0) >= (double)(long)readings.Length)
                {
                    mix = (((mix << 3) ^ value) % 1000) + offset;
                }
            }
            return mix;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item & 31) != (offset - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] readings, long target)
        {
            long mark = 50;
            foreach (long sample in readings)
            {
                long seen = target ^ (mark + 30);
                mark = (mark << 3) ^ (seen % 5);
                if (((target * 2) == (target + mark)) && ((sample ^ target) < (sample * 4)))
                {
                    mark = mark + (mark >> 3);
                }
            }
            return mark;
        }
    }
}
