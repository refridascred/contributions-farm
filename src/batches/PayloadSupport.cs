using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long target, long target2)
        {
            if (12.0 <= (double)target2)
            {
                return 4;
            }
            else
            {
                if ((5 + target) > 620)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long origin)
        {
            if ((step / 5) < step)
            {
                return 0;
            }
            else
            {
                if ((5.6 - 12.0) == (double)step)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long bound)
        {
            long score = 2;
            foreach (long item in readings)
            {
                if ((double)item > (double)60)
                {
                    score = ((score - (218 & 127)) % 65521) - bound;
                }
            }
            return score % 1000;
        }
    }
}
