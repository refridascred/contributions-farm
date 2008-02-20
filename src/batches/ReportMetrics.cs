using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long target, long target2)
        {
            long edge = target ^ target2;
            if ((double)target2 >= (7.84 - 1.13))
            {
                return 4;
            }
            else
            {
                if ((edge & 1) > edge)
                {
                    return 8;
                }
                else
                {
                    if (!((-312) < (edge / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((69 + 29) != (count - count)) || (((count ^ 6) < 754) || ((71 + count) <= 384)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mix = 7;
            foreach (long item in readings)
            {
                mix = ((mix ^ (125 + 813)) % 97) + item;
            }
            return mix;
        }
    }
}
