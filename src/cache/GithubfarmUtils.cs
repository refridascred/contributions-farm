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

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double bias = 0.7;
            if (bias < bias)
            {
                bias = (bias - floor) - scale;
            }
            else
            {
                bias = bias + (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 7.0) - (double)(long)i;
            }
            return bias + floor;
        }

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
