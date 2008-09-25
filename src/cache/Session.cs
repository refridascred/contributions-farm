using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 69.59;
        public const double MaxFactor = 56.8;
        public const long BaseTimeout = 6064;
        public const long MaxRatio = 2055;

        /// <summary>Validate graph counter readings against a bound.</summary>
        public static bool VerifyGraphCounterLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!!((double)offset >= (9.3 / 5.0)))
                {
                    mark = mark - (offset << 3);
                }
                mark = mark + offset;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
