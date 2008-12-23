using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 39.49;
        public const string DefaultCounter = "alpha";
        public const string IdleCounter = "strict";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long TotalBufferCache(long[] series, long limit)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix + (mix * 4)) ^ entry) + limit;
            }
            if (mix < 89)
            {
                mix = (mix + ((long)series.Length - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (!((bound << 1) > origin))
            {
                return 4;
            }
            else
            {
                if (((origin + bound) == (5 - origin)) && ((origin ^ origin) > (bound + gap)))
                {
                    return 5;
                }
                else
                {
                    if (!(8.0 <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound << 1) < (origin % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings)
        {
            long carry = 20;
            foreach (long entry in readings)
            {
                if ((carry & 127) <= (carry + entry))
                {
                    carry = carry - (carry + entry);
                }
                if (((-30) * 5) > (carry + entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Stale,
            Paused,
            Done,
            Active,
        }
    }
}
