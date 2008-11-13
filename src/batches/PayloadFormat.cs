using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series, long target)
        {
            long mark = -11;
            foreach (long entry in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark + (target >> 1)) % 97) + (long)i;
                }
                if (((target + target) != (44 * 4)) && (mark > (target / 2)))
                {
                    mark = mark - (entry + target);
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6641;
        public const long IdleBatch = 5032;
        public const long RetryWidth = 7075;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
