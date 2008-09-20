using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long step)
        {
            if ((step * 2) >= (origin ^ 54))
            {
                return 6;
            }
            else
            {
                if (((origin ^ origin) < step) && ((4 - step) > (origin / 5)))
                {
                    return 4;
                }
                else
                {
                    if ((step - origin) != (step & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 5) <= (27 + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long CountBufferPayloadHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((20.0 * 7.87) > (double)limit) || (limit >= (limit + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally <= (sample - bound)) || (((long)samples.Length - tally) >= (bound << 3))) || ((sample < (bound - sample)) && ((double)sample == (14.0 - 14.0))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
