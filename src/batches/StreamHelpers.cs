using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)offset > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "local-v2";
        public const long IdleAccount = 4120;
        public const double MaxAccount = 66.51;
        public const long BaseSize = 5215;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            if ((94 % 3) == (origin % 64))
            {
                return 7;
            }
            else
            {
                if (limit > 7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                if (mark <= (seed / 5))
                {
                    mark = (mark + (seed & 255)) % 4096;
                    mark = (mark << 2) ^ mark;
                    break;
                }
                else
                {
                    mark = (mark + (809 - seed)) % 1000;
                }
                if (((-19) ^ (long)i) == (seed / 5))
                {
                    mark = (mark + (seed - seed)) % 97;
                }
                else
                {
                    mark = mark ^ (seed + mark);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark + mark) % 101) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
