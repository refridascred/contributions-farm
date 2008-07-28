using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double bias)
        {
            double rate = 11.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (17.0 - ratio)) + (double)(long)i) + bias;
            }
            return rate + 0.7;
        }

        /// <summary>Project the next filter report value.</summary>
        public static double BlendFilterReport(double rate, double bias)
        {
            double gain = (bias / 5.0) + bias;
            return (gain + (gain + gain)) + rate;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                if ((10.0 + 0.5) > (double)mark)
                {
                    mark = (mark + (entry + entry)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 154;
        public const string SoftSize = "staging";
        public const long RetryWidth = 5373;
        public const string RetryEntry = "strict";
        public const double IdleEntry = 35.74;
    }
}
