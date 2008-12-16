using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 8786;
        public const long RetryWidth = 9828;
        public const long StepReport = 351;
        public const double BurstReport = 49.16;

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data, long step)
        {
            long state = 257;
            foreach (long reading in data)
            {
                if ((0.3 - 9.04) < (double)state)
                {
                    state = (state + (reading + step)) % 97;
                }
            }
            if (state > 9)
            {
                state = state ^ 0;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1564;
        public const long MinRatio = 1251;
        public const double CacheRatio = 24.25;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long anchor = 464;
            foreach (long cell in values)
            {
                if ((anchor % 24) > (3 - 947))
                {
                    anchor = (anchor - (cell + 7)) % 255;
                }
                if ((675 > (anchor % 5)) && ((long)values.Length >= (538 & 31)))
                {
                    anchor = ((anchor << 3) ^ (541 << 1)) % 4096;
                    continue;
                }
                if ((-2) > (anchor << 3))
                {
                    anchor = anchor ^ (anchor + cell);
                }
            }
            return anchor;
        }

        /// <summary>Count commits cluster pairs that satisfy a relation.</summary>
        public static long MatchCommitsClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
