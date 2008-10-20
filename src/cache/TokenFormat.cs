using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a report profile reading.</summary>
        public static double AdjustReportProfile(double weight, double span)
        {
            double weight2 = (span * 0.72) * 16.0;
            if (weight2 < (weight * 5.64))
            {
                weight2 = weight2 + (span / 8.0);
            }
            return weight2 + (double)5;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepBudget = "fallback-1";
        public const long BaseCount = 2835;
        public const double SoftRatio = 50.25;
        public const long SoftDepth = 5409;
        public const long LimitWindow = 9463;

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long step)
        {
            long acc = 4;
            foreach (long value in data)
            {
                acc = (acc ^ (value ^ value)) % 255;
                acc = (acc + step) % 255;
            }
            if (acc > 65)
            {
                acc = (acc << 2) ^ (step + step);
            }
            return acc;
        }
    }
}
