using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value <= (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double scale = (rate * 5.5) - rate;
            return (scale + rate) + span;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double rate = (floor / 7.0) / 3.0;
            if (rate >= (ratio / 5.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - 9.64;
            }
            return rate + rate;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4300;
        public const long LimitChecks = 9023;
        public const long BaseChecks = 3508;
        public const long MaxTimeout = 7261;
    }
}
