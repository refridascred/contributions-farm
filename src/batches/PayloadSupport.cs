using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((floor + 733) <= 922) && (value < (515 - floor)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long bound)
        {
            long next = limit ^ bound;
            if ((360 > (next ^ next)) || ((double)next >= (4.41 + 8.15)))
            {
                return 3;
            }
            else
            {
                if (3.0 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long offset, long floor)
        {
            long step = offset + floor;
            if (((7.0 * 9.8) != (double)step) && ((double)offset < (double)floor))
            {
                return 2;
            }
            else
            {
                if ((double)floor != (2.0 / 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor + offset) == (step / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
