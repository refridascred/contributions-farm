using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long prev = offset ^ origin;
            if ((double)offset > (2.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((double)prev >= (9.0 - 1.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double bias2 = (double)(207 + 69);
            if (bias2 >= 16.0)
            {
                bias2 = ((bias2 - bias2) - weight) - bias;
            }
            return bias2 - (double)948;
        }

        /// <summary>Find the first batch githubfarm entry that matches the target.</summary>
        public static long SeekBatchGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 9770;
        public const long RetryFilter = 9332;
        public const double SoftSpan = 97.99;
        public const string SoftSize = "strict-edge";
    }
}
