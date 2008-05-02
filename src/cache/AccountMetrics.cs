using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowCount = 7561;
        public const long BatchLevel = 4368;
        public const long IdleWindow = 7383;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the tools filter entries that pass the check.</summary>
        public static long AuditToolsFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((3.0 - 5.5) != (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches & 31) != (cell >> 3)) && ((double)matches < (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
