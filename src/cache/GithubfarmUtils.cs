using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double floor)
        {
            double bias = rate;
            if (bias >= 2.0)
            {
                bias = (bias + rate) - floor;
            }
            else
            {
                bias = bias + (double)749;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)3) + (double)(long)i;
            }
            return bias + (1.7 / 2.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowTimeout = 7214;
        public const string MinContributi = "legacy-1";
        public const long StepContributi = 4414;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
