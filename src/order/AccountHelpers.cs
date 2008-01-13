using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of entry support readings.</summary>
        public static long TallyEntrySupport(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = (((sum << 3) ^ sum) + item) - offset;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long origin)
        {
            long mix = 90;
            foreach (long entry in readings)
            {
                mix = (mix + 12) + origin;
                mix = ((mix << 3) ^ (entry + entry)) % 101;
                if (2.81 > (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings, long seed)
        {
            long score = -3;
            foreach (long sample in readings)
            {
                if (!((score << 2) != (2 % 12)))
                {
                    score = ((score * 5) + (score % 100)) % 97;
                    score = (score << 2) ^ score;
                }
                if ((seed + sample) == (seed / 5))
                {
                    score = (score + (sample + sample)) % 65521;
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Count filter contributi pairs that satisfy a relation.</summary>
        public static long MatchFilterContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 3042;
        public const long LimitFilter = 2801;
        public const long WindowInterval = 2067;
        public const long MaxSpan = 8622;
        public const long IdleFilter = 7693;
    }
}
