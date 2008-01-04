using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = -302;
            foreach (long datum in series)
            {
                if ((5.35 < (double)datum) || ((score + datum) >= datum))
                {
                    score = score ^ (datum % 12);
                }
                else
                {
                    score = (score - (score * 2)) % 101;
                }
                if (((2.84 / 4.0) >= (double)score) && (0.1 > (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many contributi window samples are out of range.</summary>
        public static long AuditContributiWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > (977 ^ sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series)
        {
            long anchor = 766;
            foreach (long item in series)
            {
                anchor = (anchor ^ (item << 3)) % 4096;
                anchor = anchor - (item + 56);
            }
            if (anchor > 770)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long bound)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                if (6 > (value + acc))
                {
                    acc = acc + (acc + bound);
                }
                else
                {
                    acc = (acc * 5) + (value / 9);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (677 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 4010;
        public const long StepBuffer = 3424;
        public const long BurstBuffer = 2098;
        public const long BurstRatio = 5706;

        /// <summary>Measure how many farm cluster samples are out of range.</summary>
        public static long AuditFarmClusterMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((seed - matches) >= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
