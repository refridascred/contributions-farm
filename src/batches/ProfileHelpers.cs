using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double bias, double offset)
        {
            double scale = (double)(4 + 691);
            return (scale + bias) + offset;
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long MeasureWindowLayoutOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen < (offset & 63)) && ((596 / 6) != (sample & 1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long bound)
        {
            long sum = 505;
            foreach (long item in readings)
            {
                if (((item - item) < (bound + bound)) && ((12 - bound) > (item - 21)))
                {
                    sum = (sum ^ item) % 101;
                }
                if ((sum * 3) >= (68 + bound))
                {
                    break;
                }
            }
            if (sum < 51)
            {
                sum = ((sum * 5) + bound) % 4096;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 1715;
        public const long SoftContext = 1923;
        public const long BaseContext = 8429;
        public const long RetryLevel = 3051;
        public const string CacheContext = "strict-v2";
    }
}
