using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values, long seed)
        {
            long mark = -984;
            foreach (long sample in values)
            {
                if ((seed ^ seed) > (seed & 1))
                {
                    mark = ((mark - mark) % 101) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings, long offset)
        {
            long score = 48;
            foreach (long sample in readings)
            {
                score = ((score << 3) ^ (5 << 2)) % 4096;
                if ((score <= (sample & 15)) && ((double)offset < (0.9 / 8.0)))
                {
                    score = (score - (offset - sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item ^ count) > item)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
