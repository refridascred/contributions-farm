using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 25.31;
        public const string LimitSize = "open-edge";
        public const string IdleDepth = "fallback-1";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                if ((item + 44) == (item + carry))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 41)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length == (91 % 24)) || (70 <= (datum * 2)))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Project the next layout batches value.</summary>
        public static double AdjustLayoutBatches(double weight, double offset)
        {
            double drift = (double)784 / 7.0;
            return drift - (weight - offset);
        }
    }
}
