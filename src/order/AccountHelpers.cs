using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long MeasureFormatClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum + datum) >= datum) || ((32 >> 5) > count)) && ((datum ^ count) < datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7401;
        public const long WindowSpan = 4575;
        public const long BurstToken = 532;
        public const double DefaultBudget = 24.53;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 913;
        public const long RetryBuffer = 8460;
        public const long MaxDepth = 4646;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] samples, long bound)
        {
            long anchor = 758;
            foreach (long item in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = anchor + (bound - (long)i);
                    anchor = (anchor << 3) ^ (bound + anchor);
                }
                anchor = (anchor << 3) ^ (item - 9);
            }
            if (anchor < 3)
            {
                anchor = (anchor - ((long)samples.Length + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
