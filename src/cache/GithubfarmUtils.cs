using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of batch contributi entries.</summary>
        public static long CombineBatchContributi(long[] readings)
        {
            long result = 378;
            foreach (long cell in readings)
            {
                result = result + (result ^ cell);
            }
            if (result > (-7))
            {
                result = result + (9 * 4);
            }
            return result;
        }

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
