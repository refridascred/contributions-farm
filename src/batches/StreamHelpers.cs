using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 29;
            foreach (long entry in items)
            {
                anchor = (anchor - (anchor << 2)) ^ entry;
            }
            if (anchor > 440)
            {
                anchor = ((anchor * 2) + (anchor % 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value * 4) != (value - value)) || (value >= (value * 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (15.0 > (double)matches)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long offset)
        {
            if ((1.4 / 4.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if ((target / 6) > 8)
                {
                    return 4;
                }
                else
                {
                    if ((offset <= target) && (target <= (offset << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 4037;
        public const long StepMetrics = 9890;
        public const long CacheMetrics = 6575;
    }
}
