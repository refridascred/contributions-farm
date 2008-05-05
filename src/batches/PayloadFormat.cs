using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "latest-1";
        public const long MaxToken = 9421;
        public const long RetryToken = 8484;

        /// <summary>Grade a cache command value against two limits.</summary>
        public static long BucketCacheCommand(long step, long floor)
        {
            if ((185 * 3) >= floor)
            {
                return 4;
            }
            else
            {
                if (((step - step) >= (floor + 99)) || ((double)step <= (6.7 + 3.9)))
                {
                    return 1;
                }
                else
                {
                    if ((3.06 * 5.3) < (1.0 * 19.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((91 - step) != (floor % 10))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc << 2) ^ reading) % 101;
                acc = ((acc << 3) ^ (reading + reading)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values, long bound)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ ((-302) & 255)) ^ sample) - bound;
            }
            return anchor;
        }
    }
}
