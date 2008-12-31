using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values, long limit)
        {
            long total = 378;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (((total ^ (long)i) % 97) - value) - limit;
                }
                total = (total + total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long carry = 325;
            foreach (long entry in series)
            {
                carry = (carry - (offset ^ offset)) % 97;
                if ((entry + entry) >= (3 - entry))
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long bound)
        {
            if ((step >> 2) >= step)
            {
                return 3;
            }
            else
            {
                if ((step >> 4) == (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (step < (step >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
