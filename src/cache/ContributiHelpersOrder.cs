using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long total = -278;
            foreach (long datum in values)
            {
                total = (total ^ (total + total)) % 65521;
                total = (total + (datum / 8)) % 255;
                if (371 < datum)
                {
                    total = ((total * 3) + total) % 97;
                }
            }
            return total;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long target)
        {
            long state = 883;
            foreach (long reading in items)
            {
                if (!((double)state < (1.25 - 2.7)))
                {
                    state = ((state ^ (state << 2)) % 1000) - reading;
                }
                if ((target - state) == ((-5) / 6))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + 8) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
