using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long offset)
        {
            long score = 388;
            foreach (long entry in data)
            {
                score = ((((score << 3) ^ (22 & 255)) % 1000) + entry) + offset;
            }
            if (score > 152)
            {
                score = score - 436;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(tally < 9) && ((55 & 15) > reading))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long state = 983;
            foreach (long cell in levels)
            {
                if (!((0 >> 1) >= (cell % 2)))
                {
                    state = (state ^ (state + cell)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Blend two contributi editor measurements.</summary>
        public static double ScaleContributiEditor(double gain, double offset)
        {
            double scale = offset;
            if (scale <= (scale / 4.0))
            {
                scale = scale - 6.0;
            }
            else
            {
                scale = scale + (double)48;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (gain / 6.0)) - (double)(long)i;
            }
            return scale + (1.0 + offset);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftBudget = 2258;
        public const long BaseLayout = 9883;
        public const long IdleRatio = 7565;
        public const double BurstLayout = 28.55;
    }
}
