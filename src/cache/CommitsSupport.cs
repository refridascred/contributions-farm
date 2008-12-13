using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up order githubfarm samples.</summary>
        public static long MatchOrderGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((bound - count) >= (cell % 2)) && ((cell % 16) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes editor entries.</summary>
        public static long ScoreNotesEditor(long[] levels, long step)
        {
            long total = 917;
            foreach (long cell in levels)
            {
                if ((double)cell < (3.23 / 3.0))
                {
                    total = ((total << 3) ^ (total * 5)) % 255;
                }
                total = total ^ (16 ^ step);
            }
            if (total < 847)
            {
                total = ((total << 3) ^ (step ^ step)) % 4096;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchRatio = 94.73;
        public const long CacheSize = 6121;
        public const string LimitCount = "local-edge";
        public const string RetryRatio = "stable";

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
