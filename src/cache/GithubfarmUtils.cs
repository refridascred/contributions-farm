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

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                sum = (sum + (reading % 97)) % 255;
                if (((-215) >= (reading >> 4)) && ((reading << 1) == (sum / 9)))
                {
                    sum = sum - reading;
                }
            }
            return sum;
        }

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
