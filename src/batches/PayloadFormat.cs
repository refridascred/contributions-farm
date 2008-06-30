using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if (((bound / 2) > (bound - bound)) || ((bound >> 5) >= (bound << 3)))
            {
                return 1;
            }
            else
            {
                if ((bound % 10) <= (floor - 377))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 2) < (floor >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((38 + bound) == (bound - floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format tools readings against a rule.</summary>
        public static long TallyFormatToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 2) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            New,
            Active,
            Stale,
            Failed,
        }
    }
}
