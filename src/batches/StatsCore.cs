using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardTimeout = "staging-1";
        public const long BatchInterval = 5259;
        public const long RetryCount = 9180;
        public const long MaxStats = 8159;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings, long step)
        {
            long mark = 535;
            foreach (long datum in readings)
            {
                if ((double)mark < (9.0 - 4.0))
                {
                    mark = (((mark << 3) ^ (step >> 4)) % 101) ^ datum;
                }
            }
            if (mark < 197)
            {
                mark = mark + (mark + step);
            }
            return mark;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinDepth = 1457;
        public const string CacheWidth = "open-v2";
        public const string IdleGithubfarm = "staging-edge";
        public const double BurstTimeout = 10.14;
        public const long BurstGithubfarm = 7126;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
