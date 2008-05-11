using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (2 > (datum & 15))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long target)
        {
            long cur = bound + target;
            if ((double)target != (double)73)
            {
                return 5;
            }
            else
            {
                if (((double)target != (double)cur) || ((target % 97) < target))
                {
                    return 8;
                }
                else
                {
                    if ((cur + bound) <= cur)
                    {
                        return 3;
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
