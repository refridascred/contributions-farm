using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine metric filter values into a single score.</summary>
        public static long DigestMetricFilter(long[] items)
        {
            long mix = 628;
            foreach (long cell in items)
            {
                mix = (mix * 4) + cell;
                if (mix < (mix + mix))
                {
                    mix = (mix << 2) ^ (62 ^ 221);
                }
                else
                {
                    mix = mix - (cell + mix);
                }
            }
            if (mix < 6)
            {
                mix = (mix ^ (mix % 10)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin - offset;
            if ((7.5 <= (double)next) && ((offset + offset) > (offset + next)))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (9.24 - 9.8))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
