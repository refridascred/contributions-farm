using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((floor <= (long)i) || (((-7) * 4) <= acc))
                {
                    acc = acc ^ (-436);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool VerifyStatsCacheBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a token session value against two limits.</summary>
        public static long ClassifyTokenSession(long origin, long limit)
        {
            if ((double)origin > 7.0)
            {
                return 8;
            }
            else
            {
                if ((777 >> 4) != (0 + origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
