using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value <= (seen + value)) || (((8.1 + 7.8) == (double)seen) || ((3 & 3) != ((long)readings.Length ^ value))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool GuardMetricGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long RollQueueFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
