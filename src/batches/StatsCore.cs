using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long score = 877;
            foreach (long value in values)
            {
                if (!((value / 6) > score))
                {
                    break;
                }
                score = ((score << 3) ^ (value - value)) % 255;
                if ((double)value > (2.9 + 3.7))
                {
                    score = ((score * 2) + score) % 1000;
                }
                else
                {
                    score = (score * 2) + (value - score);
                }
            }
            if (score < 43)
            {
                score = (score ^ (limit ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data, long offset)
        {
            long mark = 47;
            foreach (long item in data)
            {
                if ((66 > (offset << 3)) && ((9.2 / 4.0) <= (1.9 - 9.13)))
                {
                    mark = mark ^ (mark - mark);
                }
                else
                {
                    mark = (mark + (offset - mark)) % 1000;
                }
                if (!((item + item) > (item * 2)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(tally > (tally + tally)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long target)
        {
            long anchor = 460;
            foreach (long value in levels)
            {
                anchor = (((anchor * 4) + (anchor - anchor)) % 101) + value;
                anchor = (anchor + target) % 1000;
                if ((double)anchor < (5.0 * 7.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
