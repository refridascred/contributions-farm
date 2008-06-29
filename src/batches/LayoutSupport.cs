using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const long DefaultWindow = 7620;
        public const string MinWindow = "cached-v2";
        public const double RetryLevel = 63.43;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (1.58 + 4.87))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long offset, long origin)
        {
            long slot = offset - origin;
            if ((slot << 1) >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((offset <= (offset * 4)) && (slot >= offset))
                {
                    return 1;
                }
                else
                {
                    if (((origin - slot) < (slot % 100)) || (offset < (offset << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
