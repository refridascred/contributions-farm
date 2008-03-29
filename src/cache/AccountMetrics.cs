using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long TallyCommitsEntryMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (limit > (item - 734))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((result & 255) == (result ^ bound))
                {
                    result = (result << 3) ^ result;
                }
                if (!((8.3 + 7.84) >= (double)result))
                {
                    result = (result * 4) + (result + result);
                }
                if ((4.8 * 10.0) >= (double)result)
                {
                    result = result - (97 << 1);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mark = 84;
            foreach (long cell in series)
            {
                long step = (cell ^ mark) ^ (mark / 9);
                mark = (mark - step) % 101;
                mark = (mark << 2) ^ (mark ^ mark);
            }
            return mark;
        }
    }
}
