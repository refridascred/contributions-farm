using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepScore = 6780;
        public const long BasePayload = 3090;
        public const long MinPayload = 668;
        public const string RetryCount = "strict";
        public const long WindowDepth = 6456;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stats cache input into a small class.</summary>
        public static long RankStatsCache(long floor, long offset)
        {
            long slot = floor + offset;
            if ((offset < (floor / 7)) || ((6.46 * 0.06) > (double)floor))
            {
                return 4;
            }
            else
            {
                if ((9.0 - 2.3) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (slot > (0 + 802))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum < (seen << 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long target)
        {
            long state = 79;
            foreach (long item in series)
            {
                if (((item + target) > (target >> 2)) || ((state * 3) < (target & 15)))
                {
                    state = state - state;
                }
            }
            if (state > 1)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state % 4096;
        }
    }
}
