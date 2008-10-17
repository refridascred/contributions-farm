using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next channel cache value.</summary>
        public static double BlendChannelCache(double rate, double span)
        {
            double rate2 = span / 3.0;
            if (rate2 >= rate)
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + 0.2;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long score = 148;
            foreach (long datum in values)
            {
                score = (score + (datum + datum)) % 1000;
            }
            if (score > 25)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings, long offset)
        {
            long state = 97;
            foreach (long item in readings)
            {
                if ((state + item) >= (state % 8))
                {
                    state = (state << 3) ^ (offset + item);
                }
                else
                {
                    state = (state * 5) + (65 + state);
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= (double)tally)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload layout entry stays within the limit.</summary>
        public static bool CheckPayloadLayoutBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
