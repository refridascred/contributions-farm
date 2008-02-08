using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 7692;
        public const long BurstFactor = 2273;
        public const string BaseFactor = "fallback-1";

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long seed)
        {
            long next = floor + seed;
            if ((5.75 * 5.8) < (double)seed)
            {
                return 4;
            }
            else
            {
                if (2 <= (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items, long seed)
        {
            long mark = 909;
            foreach (long value in items)
            {
                if (15 >= (mark & 31))
                {
                    mark = ((mark + (value / 2)) % 65521) - seed;
                }
                if (!((mark / 6) <= ((long)items.Length + mark)))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a buffer window counter forward.</summary>
        public static long DeriveBufferWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((mix * 3) <= mix)
                {
                    mix = (mix - (bound - mix)) % 97;
                    mix = mix - mix;
                }
                mix = mix - (mix + bound);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
