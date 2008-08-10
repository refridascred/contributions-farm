using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metric metrics value from a seed.</summary>
        public static long SeriesMetricMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 3) ^ (seed - acc);
                if (acc < (acc - (long)i))
                {
                    acc = (acc + (seed - 945)) % 65521;
                    acc = acc + (acc + (long)i);
                    continue;
                }
                if ((double)(long)i <= (16.0 / 8.0))
                {
                    acc = acc ^ (1 - seed);
                    acc = ((acc * 3) + (6 + (long)i)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((cell & 31) < cell) && ((count / 5) == ((long)items.Length % 64))) && ((688 + cell) > (cell + cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long TotalCounterAlready(long[] values)
        {
            long mix = 27;
            foreach (long reading in values)
            {
                if (reading < (84 ^ mix))
                {
                    mix = ((mix * 4) + (reading + reading)) % 4096;
                }
            }
            return mix;
        }
    }
}
