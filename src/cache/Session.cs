using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 9956;
        public const double BurstSize = 40.81;
        public const long SoftSize = 4100;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
