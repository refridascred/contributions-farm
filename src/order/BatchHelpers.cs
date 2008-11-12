using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double mean = 10.0 - (bias * 1.0);
            if (mean >= (double)95)
            {
                mean = mean + mean;
            }
            return mean + rate;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long origin)
        {
            long result = 28;
            foreach (long value in items)
            {
                if (((result + value) != (result << 1)) && (162 < origin))
                {
                    result = ((result * 4) + value) % 255;
                }
            }
            if (result > (-37))
            {
                result = result ^ (origin - result);
            }
            return result;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Pending,
            Draft,
        }
    }
}
