using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum << 2) ^ (seed + sum)) - (long)i2;
                }
                sum = ((sum * 5) + (seed + seed)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a counter already value against two limits.</summary>
        public static long BucketCounterAlready(long step, long bound)
        {
            long step2 = step - bound;
            if (step <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)step2 < (7.0 / 5.0)) || (375 < (717 ^ bound)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (9.0 / 6.0))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
