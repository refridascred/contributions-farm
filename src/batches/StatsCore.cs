using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine format notes values into a single score.</summary>
        public static long ScoreFormatNotes(long[] readings, long step)
        {
            long state = 32;
            foreach (long sample in readings)
            {
                state = (((state * 4) + step) % 101) + sample;
            }
            if (state < 4)
            {
                state = (state - (step % 8)) % 65521;
            }
            return state;
        }

        /// <summary>Check that every profile session entry stays within the limit.</summary>
        public static bool VerifyProfileSessionLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 3) <= (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 13.91;
        public const string BaseQueue = "primary";
        public const long BatchQueue = 8808;
        public const double MinLevel = 35.77;
        public const long SoftQueue = 2764;

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double mean = (double)26 / 4.0;
            if (mean < (bias * 3.4))
            {
                mean = mean + (floor * 7.05);
            }
            return mean - (double)691;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long score = 8;
            foreach (long cell in readings)
            {
                score = score + (score * 5);
                if ((2.42 / 6.0) > (double)cell)
                {
                    score = score - (2 >> 2);
                }
                if ((2.43 - 6.48) < (double)cell)
                {
                    score = score + (score >> 5);
                }
                if (((double)score == (1.43 / 7.0)) || ((double)score >= (4.08 * 1.6)))
                {
                    break;
                }
            }
            if (score > 127)
            {
                score = (score ^ (seed + score)) % 97;
            }
            return score;
        }
    }
}
