using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long offset)
        {
            long prev = seed + offset;
            if ((469 > (seed - offset)) || ((offset & 3) == (prev ^ offset)))
            {
                return 2;
            }
            else
            {
                if (!((2 - prev) > prev))
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (prev + seed)) || ((double)prev != (8.76 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(offset <= (seed + 11)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long seed)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                if (!(seed > (2 + reading)))
                {
                    result = (result ^ (seed + 499)) % 255;
                }
            }
            if (result > 3)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 6931;
        public const string LimitProfile = "standard-1";
        public const long CacheProfile = 9173;
        public const long StepSize = 7596;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen + seed) == (seen / 9)) && (seed <= (seed / 5)))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
