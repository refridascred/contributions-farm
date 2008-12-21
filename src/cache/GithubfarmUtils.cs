using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((value >> 4) == (51 % 10)) || ((value * 2) <= (value * 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (-48)) % 255;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
