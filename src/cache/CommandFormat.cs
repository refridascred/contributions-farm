using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long CountPayloadRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (datum - seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double ratio = (scale * 8.2) * 8.0;
            if (ratio > (floor - ratio))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (1.0 * 8.59)) - (double)(long)i;
            }
            return ratio + (scale + 5.1);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (3 >= (7 + count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
