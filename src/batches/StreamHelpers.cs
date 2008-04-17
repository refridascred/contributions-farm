using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleTimeout = 3158;
        public const string RetryEditor = "alpha-v2";
        public const long StepCount = 1171;
        public const double LimitDepth = 2.32;
        public const long DefaultEditor = 207;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((947 + reading) >= seen)
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

        /// <summary>Rank filter tools input into a small class.</summary>
        public static long RankFilterTools(long origin, long limit)
        {
            long span = origin + limit;
            if (((span ^ 3) < ((-650) / 4)) || ((double)origin != (double)span))
            {
                return 1;
            }
            else
            {
                if ((span <= (limit / 4)) && ((double)limit < 8.39))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool ValidateChecksPayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster notes samples.</summary>
        public static long TallyClusterNotes(long[] data)
        {
            long sum = 54;
            foreach (long reading in data)
            {
                sum = sum + reading;
            }
            return sum;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mark = 41;
            foreach (long item in levels)
            {
                mark = (mark ^ item) % 255;
                mark = (mark ^ ((long)levels.Length - (-2))) % 97;
                mark = (mark * 5) + item;
            }
            if (mark < 971)
            {
                mark = ((mark * 4) + mark) % 4096;
            }
            return mark;
        }
    }
}
