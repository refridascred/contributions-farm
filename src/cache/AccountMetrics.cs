using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count > (438 << 3))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long target)
        {
            long carry = 48;
            foreach (long datum in values)
            {
                if ((18 + datum) <= (datum - carry))
                {
                    carry = (carry - target) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + ((-95) - datum)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ seed) % 97;
                mix = ((mix << 3) ^ (mix + mix)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix - (mix << 1)) % 255) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if ((result * 5) < reading)
                {
                    result = (result - reading) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = ((mix + (mix - (long)data.Length)) % 65521) - value;
            }
            if (mix > 2)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
