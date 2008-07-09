using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values, long step)
        {
            long sum = -90;
            foreach (long item in values)
            {
                if (((long)values.Length - 3) >= (item << 1))
                {
                    sum = ((sum - (1 + item)) % 255) + step;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Paused,
            Active,
            New,
            Locked,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double bias = 1.62 - (weight * 8.07);
            if (bias < (double)9)
            {
                bias = (bias + 17.0) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - 2.0) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long step)
        {
            long offset = limit ^ step;
            if (!((limit & 7) == (limit + step)))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) <= limit)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading & 7) < (tally ^ 8)) && !((reading / 2) != (tally ^ offset)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryBudget = 17.0;
        public const double StepToken = 55.47;
        public const long BatchToken = 7987;
    }
}
