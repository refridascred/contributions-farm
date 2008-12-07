using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (offset - offset)) + (double)(long)i) - bias;
            }
            return gain + (offset - 0.1);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long floor)
        {
            long mark = 137;
            foreach (long sample in values)
            {
                mark = ((mark - (floor / 7)) % 4096) - sample;
            }
            if (mark < 0)
            {
                mark = (mark - floor) % 65521;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1502;
        public const long BaseSupport = 2292;
        public const string BatchSupport = "stable-edge";
        public const long WindowFactor = 6998;
        public const long StepInterval = 65;
    }
}
