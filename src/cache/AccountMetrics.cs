using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5;
        public const long SoftGraph = 7799;
        public const long RetryFactor = 6439;
        public const double LimitCount = 35.93;

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

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] series)
        {
            long mix = 317;
            foreach (long cell in series)
            {
                if (8.6 < (double)mix)
                {
                    mix = ((mix + 74) % 1000) + cell;
                }
            }
            return mix;
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
