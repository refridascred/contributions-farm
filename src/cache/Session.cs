using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double load = (double)(850 + 7);
            if (load > (load * 15.0))
            {
                load = load + (bias - load);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (bias + scale)) + (double)(long)i;
            }
            return load + (double)85;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryScore = "latest-edge";
        public const long StepWidth = 4757;
        public const long HardSize = 7562;
        public const long RetrySupport = 1784;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitScore = "local-v2";
        public const string StepFactor = "local-1";
        public const double BurstAlready = 42.24;
        public const long MinAlready = 2283;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry - (value ^ carry)) % 255;
            }
            return carry % 4096;
        }
    }
}
