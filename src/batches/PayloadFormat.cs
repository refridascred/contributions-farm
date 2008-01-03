using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 28;
        public const long WindowFactor = 7918;
        public const double SoftRatio = 0.33;
        public const string BatchStream = "alpha-1";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if (((seed >> 3) == (seed ^ 5)) || ((double)3 <= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((seed & 127) <= 78)
                {
                    return 2;
                }
                else
                {
                    if (!(578 > (seed - 0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
