using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5166;
        public const long CacheLevel = 1282;
        public const long IdleEntry = 6495;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen % 5) != (87 & 3))
                {
                    seen = ((seen + 3) ^ datum) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long seed)
        {
            long slot = step ^ seed;
            if ((1 << 2) >= step)
            {
                return 8;
            }
            else
            {
                if ((slot << 2) == (step + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step - seed) != (seed / 9)) || (4.5 < (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value != (2.31 / 2.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 9767;
        public const double BurstGithubfarm = 22.36;
        public const double MaxSize = 10.26;
    }
}
