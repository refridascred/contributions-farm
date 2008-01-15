using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long step)
        {
            if (!((step ^ step) <= step))
            {
                return 0;
            }
            else
            {
                if ((double)(-727) > (double)target)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((double)carry >= (double)9) || ((double)carry >= (3.46 * 0.2)))
                {
                    carry = (carry * 2) + (long)i;
                }
                else
                {
                    carry = (carry - limit) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((origin + (long)series.Length) <= origin)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
