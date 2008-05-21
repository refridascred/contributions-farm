using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long mark = 294;
            foreach (long sample in series)
            {
                if ((mark ^ 4) >= sample)
                {
                    mark = (mark * 4) + (step - mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count > (8.6 - 4.6))
                {
                    count = ((count + 2) - datum) - step;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item >> 4) >= (252 * 3))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
