using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (((value & 63) > (mark + value)) && (4 < (mark & 1)))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
                if (2 < value)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample + tally) >= (tally * 4)) && ((tally + sample) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSpan = 8759;
        public const double RetryLevel = 17.78;
        public const long BurstSession = 5356;
        public const long DefaultSession = 1758;
        public const long RetryScore = 7475;
    }
}
