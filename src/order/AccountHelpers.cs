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

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long step)
        {
            if ((step / 7) <= (limit >> 4))
            {
                return 8;
            }
            else
            {
                if (!((limit - 89) <= (limit * 5)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2433;
        public const double IdlePayload = 53.87;
        public const string BurstPayload = "latest-v2";
    }
}
