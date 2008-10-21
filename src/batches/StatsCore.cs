using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine window schema values into a single score.</summary>
        public static long ScoreWindowSchema(long[] samples, long origin)
        {
            long carry = -17;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (origin >> 2)) % 65521;
                carry = carry ^ (99 + origin);
                if ((double)datum <= (8.08 * 18.0))
                {
                    carry = ((carry * 4) + (datum >> 2)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (bound * 2)) % 1000;
                mark = ((mark * 5) + (bound ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 30.16;
        public const long CacheDepth = 6644;
        public const long DefaultTimeout = 3183;
        public const string MinPayload = "legacy-v2";

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long seed)
        {
            long diff = origin - seed;
            if (!((447 % 16) <= (origin - origin)))
            {
                return 5;
            }
            else
            {
                if ((4.7 - 1.23) == (double)diff)
                {
                    return 6;
                }
                else
                {
                    if (((51 + seed) <= seed) && ((diff + origin) <= (origin - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mix = -7;
            foreach (long value in readings)
            {
                mix = mix + (4 + value);
            }
            if (mix < 168)
            {
                mix = (mix * 3) + (mix + mix);
            }
            return mix % 97;
        }
    }
}
