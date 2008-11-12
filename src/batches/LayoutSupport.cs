using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a token entry pair into a bucket.</summary>
        public static long RankTokenEntry(long target, long target2)
        {
            if (((target * 5) <= target2) && ((8.18 - 14.0) < (double)target))
            {
                return 2;
            }
            else
            {
                if ((target2 + target) < (target2 + target2))
                {
                    return 4;
                }
                else
                {
                    if ((4.2 + 3.6) == (double)target2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
