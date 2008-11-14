using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long CountGithubfarmContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + matches) == (8 + matches))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3719;
        public const double MinContributi = 16.87;
        public const long CacheContributi = 4598;
        public const long LimitCount = 4655;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (bound % 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
