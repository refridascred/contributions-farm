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

        /// <summary>Rank command commits input into a small class.</summary>
        public static long RankCommandCommits(long origin, long bound)
        {
            if ((origin / 2) > bound)
            {
                return 6;
            }
            else
            {
                if (origin <= (bound / 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) < (datum - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
