using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit context layout readings against a rule.</summary>
        public static long CountContextLayoutOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally + tally) >= seed) && ((double)seed < (5.1 - 17.0)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Audit filter channel readings against a rule.</summary>
        public static long AuditFilterChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count / 2) >= (cell + cell)) || ((5 + count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen ^ 966) < 493)
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + value) <= ((long)readings.Length & 63))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
