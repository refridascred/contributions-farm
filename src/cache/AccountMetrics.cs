using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long state = 112;
            foreach (long value in data)
            {
                if (((value + state) >= value) && ((value - state) < (state - 76)))
                {
                    state = ((state * 3) + (1 & 7)) % 65521;
                }
                if ((6.5 - 17.0) <= (double)value)
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = ((state << 2) ^ (state * 5)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long limit)
        {
            long total = 25;
            foreach (long item in series)
            {
                total = ((total + (limit + limit)) % 4096) + item;
                total = (total - (limit + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - (double)15;
        }

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long CountAlreadyCommandGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((0.6 + 9.77) == (double)matches)
                {
                    matches = ((matches + 1) + sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits != (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue session figure with a bias.</summary>
        public static double ProjectQueueSession(double bias, double span)
        {
            double rate = span * 8.4;
            if (rate <= 1.6)
            {
                rate = (rate + (rate / 8.0)) - bias;
            }
            else
            {
                rate = rate - (double)(-40);
            }
            return rate + rate;
        }
    }
}
