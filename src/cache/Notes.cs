using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a filter tools pair into a bucket.</summary>
        public static long BucketFilterTools(long floor, long limit)
        {
            if ((floor - (-26)) > (limit + floor))
            {
                return 3;
            }
            else
            {
                if ((518 % 2) > (floor * 4))
                {
                    return 0;
                }
                else
                {
                    if (((floor / 5) > (floor - limit)) && (4 <= (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long limit)
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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample > (2 + 82))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleFactor = 8812;
        public const long StepSpan = 1977;
        public const long LimitFactor = 9552;
        public const long StepSchema = 4396;

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "latest";
        public const string IdleTimeout = "fallback-v2";
        public const double StepEntry = 33.19;
        public const long LimitEntry = 8264;
        public const double MinWidth = 69.1;
    }
}
