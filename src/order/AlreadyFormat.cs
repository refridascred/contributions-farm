using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long target)
        {
            if (((double)target == (4.0 - 19.0)) && ((target + origin) >= origin))
            {
                return 0;
            }
            else
            {
                if ((origin - target) < (target + origin))
                {
                    return 4;
                }
                else
                {
                    if (!((origin >> 5) <= target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target > (double)4) || ((double)target == (1.7 - 2.85)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 20.01;
        public const long StepDepth = 8423;
        public const long LimitRecord = 6223;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double load = bias;
            if (load > (load / 9.0))
            {
                load = load - (bias / 9.0);
            }
            else
            {
                load = load - load;
            }
            return load + (gain * 5.42);
        }
    }
}
