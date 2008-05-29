using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 31.49;
        public const string CacheSpan = "strict-v2";
        public const long SoftContributi = 4918;
        public const double MinContributi = 89.41;

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long bound, long target)
        {
            if (!((bound - 680) == (bound / 4)))
            {
                return 7;
            }
            else
            {
                if (8 >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((5.69 / 6.0) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((95 - 640) == (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
