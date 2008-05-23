using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double bias = (double)78 - (double)7;
            if (bias > ratio)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + span;
            }
            return bias - (span / 3.0);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long origin)
        {
            long result = 537;
            foreach (long item in values)
            {
                result = (((result << 3) ^ result) - item) - origin;
            }
            return result % 1000;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score << 3) ^ (8 * 3);
                score = (score + (limit + limit)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
