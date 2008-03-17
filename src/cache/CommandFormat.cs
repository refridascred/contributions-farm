using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] samples)
        {
            long mark = 5;
            foreach (long item in samples)
            {
                if ((item + mark) >= (mark + item))
                {
                    mark = ((mark * 2) + (7 / 9)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
