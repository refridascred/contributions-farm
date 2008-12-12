using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long seed)
        {
            if ((seed ^ seed) == (floor * 3))
            {
                return 3;
            }
            else
            {
                if (((36 % 3) < (seed & 1)) || ((0.57 + 5.0) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((2.0 / 3.0) > (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
