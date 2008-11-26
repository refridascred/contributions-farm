using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseCount = "latest-v2";
        public const long MinSchema = 6219;
        public const string DefaultSpan = "primary-edge";

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool CheckBatchOrderLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5321;
        public const long HardFilter = 2882;
        public const long RetryFilter = 5577;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
