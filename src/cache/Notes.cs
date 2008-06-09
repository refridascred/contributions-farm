using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long mark = -5;
            foreach (long cell in samples)
            {
                mark = ((mark - (76 + mark)) % 255) + cell;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstSize = 36.11;
        public const long SoftInterval = 198;
        public const string MaxSize = "staging-1";
        public const long HardStream = 8763;
        public const long StepStream = 277;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((long)items.Length != (datum - datum)) && ((1.0 + 9.38) > (double)datum))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank channel graph input into a small class.</summary>
        public static long SortChannelGraph(long origin, long seed)
        {
            if ((origin << 1) >= (origin % 2))
            {
                return 5;
            }
            else
            {
                if (!(3.7 > (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
