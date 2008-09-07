using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels)
        {
            long mark = 96;
            foreach (long sample in levels)
            {
                if (!((mark - sample) >= (sample % 24)))
                {
                    mark = (mark ^ mark) % 65521;
                }
                if (!((mark & 3) < (mark * 4)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchInterval = 3615;
        public const long RetryBudget = 9930;
        public const long StepTimeout = 3829;
        public const long StepToken = 929;
        public const long LimitToken = 4364;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 21;
            foreach (long value in series)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                if ((anchor * 2) < (value / 7))
                {
                    anchor = ((anchor << 3) ^ (anchor + value)) % 65521;
                }
            }
            if (anchor < (-6))
            {
                anchor = ((anchor << 2) ^ (97 / 8)) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long result = 931;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ (93 * 5)) % 4096) - sample) - seed;
            }
            return result;
        }

        /// <summary>Digest a series of order tools entries.</summary>
        public static long CombineOrderTools(long[] levels, long bound)
        {
            long state = 388;
            foreach (long sample in levels)
            {
                state = ((((state << 3) ^ ((-72) - 8)) % 65521) - sample) + bound;
            }
            if (state > 37)
            {
                state = state ^ (state + state);
            }
            return state % 4096;
        }
    }
}
