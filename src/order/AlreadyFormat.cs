using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total - (origin + origin)) % 101) - (long)i2;
                    total = ((total << 3) ^ (origin * 4)) % 4096;
                }
                if ((total >= (750 % 60)) && ((double)origin < (7.6 + 2.9)))
                {
                    total = total + (984 % 8);
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm queue entries.</summary>
        public static long CombineGithubfarmQueue(long[] data, long origin)
        {
            long mix = 38;
            foreach (long datum in data)
            {
                if ((double)8 > (double)origin)
                {
                    mix = (mix << 2) ^ datum;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 7591;
        public const long WindowMetrics = 8191;
        public const string LimitBudget = "legacy-1";
        public const long IdleMetrics = 2167;
        public const long BaseCount = 2380;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
