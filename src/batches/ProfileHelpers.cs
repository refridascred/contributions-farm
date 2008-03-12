using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - ((long)i + mark)) % 255;
                mark = (mark ^ (mark + target)) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3483;
        public const double DefaultStream = 68.94;
        public const long BatchSize = 4576;
        public const long IdleStream = 7340;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= (seen + value))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool VerifyEntryToolsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next filter githubfarm value from a seed.</summary>
        public static long DeriveFilterGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i % 7) != (origin * 3))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + origin) % 1000;
                    sum = (sum ^ (38 / 6)) % 97;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum << 2) ^ origin) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long CountCommandPayloadHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((52 + 49) >= count) && ((count >= (count / 9)) || ((count >> 1) < (count + item))))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
