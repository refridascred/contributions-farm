using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowCount = 98.96;
        public const long StepPayload = 5995;
        public const long IdlePayload = 4563;
        public const double LimitPayload = 78.63;
        public const double MinWidth = 13.31;

        /// <summary>Combine metric entry values into a single score.</summary>
        public static long TallyMetricEntry(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if ((mark + mark) <= cell)
                {
                    mark = (mark << 3) ^ (cell % 2);
                }
                else
                {
                    mark = (mark - cell) % 65521;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (floor2 < (floor % 12))
            {
                return 2;
            }
            else
            {
                if ((floor * 4) >= (floor2 * 4))
                {
                    return 1;
                }
                else
                {
                    if ((196 ^ 9) != (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound & 63) <= (floor2 << 3)) || ((62 % 24) == (floor2 + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
