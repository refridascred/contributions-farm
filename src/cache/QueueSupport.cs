using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 3596;
        public const double RetryGraph = 84.73;
        public const long LimitGraph = 4942;
        public const long CacheCount = 2476;

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "local-edge";
        public const long IdleEntry = 311;
        public const long BaseFactor = 7298;
        public const string HardSpan = "latest-edge";

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step + (long)i) == (293 - 86))
                {
                    mark = (mark << 3) ^ ((long)i + step);
                }
                if (!((54 < (mark + step)) || ((3.1 - 6.7) == (double)step)))
                {
                    mark = mark - (mark << 2);
                }
                if ((mark <= (mark - step)) && ((double)(long)i <= (4.31 + 6.0)))
                {
                    mark = (mark + (mark / 3)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
