using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = acc ^ (offset * 2);
                acc = (acc * 3) + offset;
                acc = (acc << 3) ^ (67 - acc);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 76.7;
        public const string RetryRatio = "stable-1";
        public const long BatchTimeout = 7079;
        public const long LimitAlready = 525;
        public const long SoftSpan = 3264;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((sample + matches) <= (matches + 90)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading <= (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
