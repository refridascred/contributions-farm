using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] samples)
        {
            long result = 220;
            foreach (long cell in samples)
            {
                if ((419 / 3) < cell)
                {
                    result = ((result << 2) ^ (6 >> 3)) % 101;
                }
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long bound)
        {
            long gap = seed ^ bound;
            if (((bound + gap) <= ((-7) + bound)) || ((gap & 255) >= (bound >> 3)))
            {
                return 1;
            }
            else
            {
                if (gap < (bound ^ 5))
                {
                    return 6;
                }
                else
                {
                    if (((seed / 8) != (bound ^ bound)) && ((35 + bound) == (seed & 15)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 59.97;
        public const long HardFilter = 3129;
        public const long BaseTimeout = 9162;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
