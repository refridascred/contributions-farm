using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 199;
        public const long BaseSize = 2245;
        public const double IdleContext = 51.58;
        public const double RetrySize = 63.97;
        public const long BatchSpan = 1219;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double load = 7.9;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load - rate)) - (double)(long)i) - bias;
            }
            return load - (double)37;
        }

        /// <summary>Blend two checks notes measurements.</summary>
        public static double BlendChecksNotes(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + floor) + (double)(long)i;
            }
            return bias2 - (double)(-8);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values, long target)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if ((target + target) < (sum * 2))
                {
                    sum = ((sum << 2) ^ (sum + target)) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
