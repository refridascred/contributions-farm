using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long DigestChecksCache(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = result - ((long)levels.Length + cell);
                if ((cell & 127) != (cell - result))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = ((result << 2) ^ (result - result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((7 - reading) < 807)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long mix = 81;
            foreach (long item in items)
            {
                if (((443 - 837) == (791 - item)) || ((item / 4) != ((-334) >> 5)))
                {
                    mix = mix ^ (item + 4);
                }
            }
            if (mix > 2)
            {
                mix = (mix << 2) ^ (mix ^ mix);
            }
            return mix % 4096;
        }
    }
}
