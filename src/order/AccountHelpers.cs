using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8346;
        public const double MaxRatio = 83.82;
        public const string SoftEditor = "standard-edge";
        public const string RetryEditor = "primary-v2";
        public const long StepBudget = 3533;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values)
        {
            long score = 782;
            foreach (long value in values)
            {
                if (!((score + 3) > (value & 127)))
                {
                    score = score - (0 ^ (-51));
                    score = (score - (score * 5)) % 97;
                }
                if ((55 + score) == (score >> 3))
                {
                    score = ((score << 3) ^ value) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < bias)
            {
                bias3 = bias3 - 0.3;
            }
            for (int i = 0; i < 6; i++)
            {
                bias3 = (bias3 - (bias / 7.0)) + (double)(long)i;
            }
            return bias3 - bias;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Failed,
            Queued,
            Draft,
        }
    }
}
