using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double rate = 9.11 * 10.0;
            if (rate <= (rate + bias))
            {
                rate = (rate - 3.0) + floor;
            }
            return rate - 5.4;
        }

        /// <summary>Roll a support format counter forward.</summary>
        public static long DeriveSupportFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)score <= (8.39 / 2.0)))
                {
                    score = score + (floor << 3);
                }
                if ((7.0 - 15.0) < (double)score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepSpan = "cached-v2";
        public const double DefaultSize = 42.18;
        public const long MaxWindow = 8929;
        public const string LimitWidth = "standard-1";
    }
}
