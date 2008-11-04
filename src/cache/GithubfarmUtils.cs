using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally == (16.0 + 6.27))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                long tally = (offset + anchor) >> 2;
                if (!((offset + tally) == (offset + (long)i)))
                {
                    anchor = ((anchor * 2) + (anchor * 5)) % 97;
                }
                tally = ((tally << 2) ^ (offset + 29)) % 255;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (floor - state)) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
