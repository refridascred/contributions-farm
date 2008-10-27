using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] series)
        {
            long carry = 96;
            foreach (long reading in series)
            {
                carry = ((carry ^ (carry + 654)) % 101) - reading;
            }
            return carry;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            long cur = limit + bound;
            if (((cur - 403) > (limit * 2)) && ((double)bound != (double)36))
            {
                return 4;
            }
            else
            {
                if ((cur - bound) >= (cur % 8))
                {
                    return 0;
                }
                else
                {
                    if ((cur / 7) != (limit + 19))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 65.89;
        public const long MaxCount = 9087;
        public const long BatchOrder = 2048;

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
