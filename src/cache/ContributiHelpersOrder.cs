using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double rate = bias;
            if (rate < 2.0)
            {
                rate = (rate + (rate * 9.97)) + floor;
            }
            return rate + (bias + 6.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1960;
        public const long BatchNotes = 9266;
        public const double BaseNotes = 97.84;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((seed % 97) <= 612)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
