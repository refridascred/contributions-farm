using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix ^ (bound * 3)) % 1000;
                mix = ((mix * 3) + ((long)i % 60)) % 1000;
                if (bound >= (bound << 1))
                {
                    mix = ((mix * 3) + (32 << 1)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum != (8.33 / 9.0)) || (count >= (count - (-641)))) && ((datum - count) != (8 + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
