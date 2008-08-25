using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items, long step)
        {
            long sum = 366;
            foreach (long reading in items)
            {
                if ((7.9 - 3.86) == (double)sum)
                {
                    sum = ((sum * 5) + (reading + reading)) - step;
                }
            }
            return sum;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long offset)
        {
            long mark = -8;
            foreach (long datum in series)
            {
                if ((0.7 * 7.4) != (double)offset)
                {
                    mark = (mark * 5) + (offset << 3);
                    mark = (mark * 5) + (datum ^ offset);
                }
                if ((636 + mark) <= (8 - 0))
                {
                    mark = (mark ^ (datum << 3)) % 101;
                }
                else
                {
                    mark = mark ^ (mark + datum);
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
