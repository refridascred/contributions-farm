using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long CountCommitsChannelHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) < hits)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Stale,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const string BaseTimeout = "local-v2";
        public const double BatchSupport = 95.09;
        public const long CacheRatio = 2327;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                if ((765 / 5) <= acc)
                {
                    break;
                }
                if (((10.0 + 5.4) == (double)acc) || ((2.0 - 9.0) >= (double)(long)i))
                {
                    acc = ((acc << 3) ^ (target + target)) % 1000;
                }
                if ((8 + target) < (acc & 7))
                {
                    acc = (acc + (507 ^ target)) % 65521;
                    acc = ((acc << 2) ^ ((long)i - target)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 3) ^ acc;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long limit)
        {
            long diff = origin + limit;
            if ((double)origin != (3.71 - 8.0))
            {
                return 7;
            }
            else
            {
                if (((8.0 * 7.4) <= (double)origin) || (diff >= (357 + limit)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
