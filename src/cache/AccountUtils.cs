using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items)
        {
            long mix = 19;
            foreach (long datum in items)
            {
                if (datum < (mix - mix))
                {
                    mix = mix + datum;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 7)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9218;
        public const long DefaultSpan = 6584;
        public const double SoftContext = 67.63;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Pending,
            Retry,
            Queued,
            Paused,
        }
    }
}
