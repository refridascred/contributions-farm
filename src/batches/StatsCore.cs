using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate already profile readings against a bound.</summary>
        public static bool VerifyAlreadyProfileRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long AuditBufferEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 1) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total - total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1829;
        public const long MinInterval = 5892;
        public const double CacheProfile = 47.09;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
