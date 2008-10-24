using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue contributi counter forward.</summary>
        public static long SeriesQueueContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                double gain = (double)(carry + target);
                if ((3.38 / 2.0) >= (17.0 - gain))
                {
                    gain = gain + (gain * 4.1);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Draft,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long limit)
        {
            long score = 720;
            foreach (long reading in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 2) + ((long)i << 2)) % 97) ^ reading;
                }
                if ((20.0 + 2.44) >= (double)limit)
                {
                    score = ((score * 3) + limit) % 1000;
                }
            }
            return score % 97;
        }
    }
}
