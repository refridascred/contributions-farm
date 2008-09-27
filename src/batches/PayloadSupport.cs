using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mix = -36;
            foreach (long cell in readings)
            {
                mix = mix - (cell % 10);
            }
            if (mix > 1)
            {
                mix = (mix + (63 * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if ((sum >> 4) <= (sum + target))
                {
                    sum = sum ^ (target + target);
                }
                else
                {
                    sum = (sum ^ (target / 5)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
