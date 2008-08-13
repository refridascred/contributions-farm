using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the checks metric series from a seed.</summary>
        public static long IterateChecksMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                if (mark <= (mark & 7))
                {
                    mark = (mark - ((long)i * 5)) % 4096;
                    mark = mark + target;
                }
                if (4 < ((long)i >> 4))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                    break;
                }
                if (((target - (long)i) <= target) || ((double)target == (10.0 * 6.29)))
                {
                    mark = (mark ^ target) % 255;
                }
                else
                {
                    mark = (mark ^ (target + (long)i)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxCount = "alpha";
        public const string MaxBuffer = "legacy-1";
        public const long BatchScore = 8446;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
