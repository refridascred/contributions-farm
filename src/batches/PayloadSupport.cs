using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next session format value from a seed.</summary>
        public static long IterateSessionFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - ((long)i + offset)) % 65521;
                if ((sum >> 3) == (577 << 1))
                {
                    sum = sum - 955;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((368 * 5) > (4 - count))
                {
                    count = ((count + 2) + value) - target;
                }
            }
            return count;
        }
    }
}
