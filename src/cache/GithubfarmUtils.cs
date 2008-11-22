using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double StepSpan = 47.67;
        public const long BaseAlready = 4846;
        public const long SoftAlready = 1475;
        public const long WindowRatio = 7022;
        public const string IdleAlready = "strict-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "open-edge";
        public const double MaxCommand = 52.29;
        public const long LimitCommand = 5256;
        public const double WindowSize = 96.94;
        public const long HardCount = 1996;

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardSpan = 67.49;
        public const long DefaultLayout = 5553;
        public const long BaseCount = 8620;
        public const double MinFactor = 72.43;

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ScaleFilterContributi(double bias, double span)
        {
            double mean = (double)(0 + 41);
            if (mean <= bias)
            {
                mean = mean - (double)353;
            }
            return mean + span;
        }
    }
}
