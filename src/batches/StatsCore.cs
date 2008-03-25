using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = (score << 2) ^ score;
                if (!(((long)i - (long)i) >= score))
                {
                    score = (score + offset) % 1000;
                    score = (score + (score + 142)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 8835;
        public const string LimitTools = "local-edge";
        public const double SoftTools = 3.72;
        public const long MinTimeout = 2631;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel payload entries that pass the check.</summary>
        public static long MeasureChannelPayloadGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((8.0 - 2.0) == (double)item) && ((item ^ count) > (item / 5)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long origin2)
        {
            if ((origin < (origin * 4)) && ((origin - 0) != (origin2 << 1)))
            {
                return 4;
            }
            else
            {
                if ((origin % 8) > (origin + origin2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long ScoreGithubfarmCache(long[] items, long limit)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (((sum ^ sample) >= (843 + 65)) || ((sum + sum) >= (limit >> 2)))
                {
                    sum = sum ^ limit;
                }
            }
            return sum;
        }
    }
}
