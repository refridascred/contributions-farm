using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length & 63) < (long)levels.Length)
                {
                    seen = ((seen + 1) ^ value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a command layout pair into a bucket.</summary>
        public static long GradeCommandLayout(long seed, long limit)
        {
            if ((limit * 3) <= limit)
            {
                return 6;
            }
            else
            {
                if ((-7) <= (limit + seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Done,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "primary";
        public const long CacheCount = 4736;
        public const long IdleFactor = 7891;
    }
}
