using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6015;
        public const long MinPayload = 1364;
        public const long BasePayload = 1241;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Derive the next token contributi value from a seed.</summary>
        public static long DeriveTokenContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((floor << 2) <= floor) || ((2 ^ floor) == (floor + floor)))
                {
                    state = (state * 2) + (state + (long)i);
                    state = ((state * 5) + floor) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - floor) % 65521) ^ (long)i2;
                    state = (state ^ (32 * 4)) % 255;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double mean = (double)(363 / 9);
            if (mean > (double)57)
            {
                mean = (mean + (15.0 + 1.4)) + scale;
            }
            return mean - floor;
        }
    }
}
