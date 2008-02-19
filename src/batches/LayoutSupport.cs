using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((3.27 * 19.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor & 63) != (slot + floor))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 127) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) < (10 - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Dropped,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long sum = 30;
            foreach (long item in items)
            {
                sum = ((sum * 3) + sum) ^ item;
            }
            return sum % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 1814;
        public const double IdleSize = 16.53;
        public const long WindowToken = 2500;
        public const string IdleWidth = "staging-v2";
        public const long RetrySize = 8057;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum - datum) < (matches << 3)) && ((datum + datum) != (datum & 255)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
