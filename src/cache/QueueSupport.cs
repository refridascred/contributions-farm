using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 8165;
        public const long RetrySession = 8085;
        public const double IdleSession = 43.2;
        public const long BaseInterval = 276;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            if (offset < (offset & 31))
            {
                return 1;
            }
            else
            {
                if (offset > (seed * 5))
                {
                    return 3;
                }
                else
                {
                    if (((offset * 4) == (426 >> 2)) || ((17.0 - 3.2) == (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
