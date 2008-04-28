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

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data, long target)
        {
            long anchor = 288;
            foreach (long reading in data)
            {
                if (anchor <= (994 - target))
                {
                    anchor = ((anchor - (anchor + target)) % 101) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 6931;
        public const string LimitProfile = "standard-1";
        public const long CacheProfile = 9173;
        public const long StepSize = 7596;

        /// <summary>Count the tools report entries that pass the check.</summary>
        public static long MeasureToolsReportMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading & 31) >= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
