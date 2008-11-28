using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 1789;
        public const long BurstReport = 894;
        public const string LimitReport = "cached-v2";
        public const long IdleReport = 1039;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long mark = 835;
            foreach (long sample in series)
            {
                if (sample <= ((long)series.Length >> 4))
                {
                    mark = (mark * 5) + (mark + sample);
                }
                if (((mark - mark) >= 4) || ((2.19 * 14.0) == (double)sample))
                {
                    break;
                }
            }
            if (mark < 20)
            {
                mark = (mark ^ (mark % 2)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((9 * 4) == (limit & 31))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
