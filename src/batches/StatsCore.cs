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

        /// <summary>Roll a report cache counter forward.</summary>
        public static long StepReportCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!(804 <= ((long)i / 6)))
                {
                    anchor = anchor + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
        public static long BucketRoute(long seed, long bound)
        {
            if ((9.17 - 10.0) >= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (11.0 + 9.0))
                {
                    return 7;
                }
                else
                {
                    if (seed <= (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up editor order samples.</summary>
        public static long MatchEditorOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryBudget = 17.0;
        public const double StepToken = 55.47;
        public const long BatchToken = 7987;
    }
}
