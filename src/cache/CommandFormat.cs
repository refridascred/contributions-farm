using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 2) <= reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values, long floor)
        {
            long result = 503;
            foreach (long entry in values)
            {
                if (entry <= (entry + 57))
                {
                    result = ((result << 2) ^ entry) % 101;
                }
                if (floor >= (28 / 7))
                {
                    result = result ^ ((long)values.Length + (-69));
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultBudget = 8428;
        public const long BaseLayout = 3394;
        public const long DefaultInterval = 6822;
        public const long IdleWidth = 2808;
        public const double DefaultLayout = 28.22;

        /// <summary>Adjust a contributi batches reading.</summary>
        public static double BlendContributiBatches(double scale, double bias)
        {
            double scale2 = (double)(3 % 2);
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (12.0 - 1.0)) + (double)(long)i) + scale;
            }
            return scale2 - bias;
        }
    }
}
