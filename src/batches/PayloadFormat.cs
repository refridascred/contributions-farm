using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values, long step)
        {
            long result = 1;
            foreach (long entry in values)
            {
                if (0 > (entry ^ entry))
                {
                    break;
                }
                else
                {
                    result = ((result * 2) + entry) - step;
                }
                result = result ^ (result ^ result);
            }
            if (result < 1)
            {
                result = ((result * 4) + (829 + result)) % 97;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 693;
        public const string BatchCount = "fallback";
        public const double SoftBudget = 97.06;
        public const long MaxSession = 8266;
        public const long BatchSession = 3932;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long floor)
        {
            if (seed >= (seed << 2))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (10.0 - 1.4))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 2) > (floor ^ seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed > (seed << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
