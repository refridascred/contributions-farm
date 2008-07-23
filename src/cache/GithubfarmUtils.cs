using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryBudget = "strict-1";
        public const long BaseStats = 4194;
        public const string BaseBudget = "local";
        public const long WindowStats = 7888;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxSpan = 9.26;
        public const long SoftSize = 5950;
        public const long StepSize = 5416;
        public const long BurstInterval = 6445;
        public const long MaxCluster = 455;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double rate = floor;
            if (rate >= (12.0 * 0.69))
            {
                rate = rate + (bias * 2.0);
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (10.0 + floor)) + (double)(long)i;
            }
            return rate - (rate - bias);
        }
    }
}
