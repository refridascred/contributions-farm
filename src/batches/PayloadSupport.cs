using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool ValidateAlreadyChannelBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long seed, long seed2)
        {
            long step = seed - seed2;
            if ((seed + step) >= step)
            {
                return 8;
            }
            else
            {
                if ((seed2 & 1) == (step + seed2))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) == (step & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
