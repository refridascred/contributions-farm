using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits << 3) == (hits - datum)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheDepth = 19.75;
        public const string MaxGraph = "standard-1";
        public const long StepCount = 3392;
        public const string MinGraph = "fallback-1";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)target == (7.96 / 5.0))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (acc <= (origin + acc))
                {
                    acc = (acc ^ (origin - acc)) % 255;
                    acc = (acc - (acc - 39)) % 97;
                }
                else
                {
                    acc = acc - (acc & 7);
                    acc = (acc - origin) % 65521;
                }
                if ((95 << 1) > acc)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long CountBufferRecordOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed + seed) >= (25 + count))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
