using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a notes order reading by value.</summary>
        public static long FindNotesOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a notes format pair into a bucket.</summary>
        public static long BucketNotesFormat(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if (((seed - seed) > seed2) && ((span ^ 94) >= (608 % 5)))
            {
                return 5;
            }
            else
            {
                if ((double)seed2 > (1.0 - 10.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 4852;
        public const double MaxBuffer = 93.94;
        public const long MinDepth = 553;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Active,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((-695) & 3) >= seen)
                {
                    seen = ((seen + 3) ^ reading) - limit;
                }
            }
            return seen;
        }
    }
}
