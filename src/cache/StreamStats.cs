using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long floor)
        {
            if ((floor * 2) < (-4))
            {
                return 3;
            }
            else
            {
                if ((20.0 - 9.0) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor >= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 6504;
        public const string RetryFactor = "strict-v2";
        public const double LimitScore = 5.98;
        public const long SoftSize = 3474;
        public const double MinStats = 74.29;

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long IterateSupportContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
