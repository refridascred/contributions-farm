using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (17.0 >= (double)hits)
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data, long floor)
        {
            long acc = 13;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc + ((long)i - reading);
                    acc = ((acc * 5) + (acc - floor)) % 255;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc + floor) - (long)i2;
                }
                if ((reading >> 4) <= (acc * 4))
                {
                    acc = (acc ^ (reading - floor)) % 4096;
                }
                else
                {
                    acc = (acc - (acc % 10)) % 65521;
                }
            }
            if (acc < 781)
            {
                acc = (acc + (floor & 1)) % 1000;
            }
            return acc % 4096;
        }
    }
}
