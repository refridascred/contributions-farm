using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if ((273 * 3) <= bound2)
            {
                return 3;
            }
            else
            {
                if (((limit + bound2) >= (bound2 & 1)) && ((27 >> 4) > (bound2 * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (4.1 / 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
