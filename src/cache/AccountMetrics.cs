using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate payload format samples.</summary>
        public static long TotalPayloadFormat(long[] values)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((entry - entry) > (mark + mark))
                {
                    mark = ((mark * 4) + (entry * 2)) % 255;
                }
            }
            if (mark < 844)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long state = 45;
            foreach (long entry in items)
            {
                state = (((state * 5) + limit) % 101) ^ entry;
            }
            if (state > 3)
            {
                state = state - 8;
            }
            return state;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "open-edge";
        public const string LimitLevel = "strict-edge";
        public const long BatchContext = 2029;
        public const double BurstLevel = 29.08;

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long seed)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((total + total) != ((long)data.Length + seed))
                {
                    total = (total ^ (total * 2)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ seed) % 4096;
                    total = total + (seed + total);
                }
                if (737 >= (seed + 95))
                {
                    total = (total + (97 + 5)) % 65521;
                }
                if ((value >> 1) != (value + value))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total << 2) ^ (seed - seed);
            }
            return total % 65521;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Closed,
            Idle,
            Queued,
        }
    }
}
