using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (296 < (reading - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long sum = 482;
            foreach (long item in samples)
            {
                if (!(((sum >> 3) > 1) && ((19.0 - 7.92) == (double)sum)))
                {
                    sum = sum + (sum >> 4);
                }
                if ((sum - item) > (sum / 5))
                {
                    sum = (sum + (sum - item)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long seed)
        {
            if (seed >= (target * 4))
            {
                return 5;
            }
            else
            {
                if ((seed * 2) <= (seed >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 6) >= (target % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.06 - 4.84) < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
