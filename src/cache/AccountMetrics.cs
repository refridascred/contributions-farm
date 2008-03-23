using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)tally > 4.1) || (tally <= (entry / 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long target)
        {
            long score = -432;
            foreach (long sample in samples)
            {
                if ((double)score <= (5.0 - 7.0))
                {
                    score = (((score * 3) + (target - score)) % 101) ^ sample;
                }
            }
            if (score > 33)
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - count) < step)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Failed,
            Synced,
            New,
        }
    }
}
