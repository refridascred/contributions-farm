using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] items, long step)
        {
            long mark = 523;
            foreach (long cell in items)
            {
                mark = (mark ^ (mark ^ 871)) - cell;
            }
            if (mark > 747)
            {
                mark = mark + (step + 6);
            }
            return mark % 4096;
        }

        /// <summary>Derive the next contributi report value from a seed.</summary>
        public static long SeriesContributiReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ offset;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinInterval = 5355;
        public const string LimitRatio = "stable";
        public const long MinLevel = 5561;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state + state) % 97) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((seed - seed) < seed))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
