using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] data, long limit)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                mix = (mix + (3 / 3)) % 97;
                if ((cell << 1) < ((-2) + 2))
                {
                    mix = (mix + (limit / 6)) % 65521;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool GuardGraphTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (2 > hits)
                {
                    hits = ((hits + 3) - value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double span)
        {
            double rate = (gain * 4.8) + span;
            if (rate >= (gain + 6.3))
            {
                rate = rate - (double)559;
            }
            else
            {
                rate = rate + (rate * 8.7);
            }
            return rate - (gain / 8.0);
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((-445) % 100) == (long)i)
                {
                    carry = (carry - (long)i) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
