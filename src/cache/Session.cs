using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > (floor ^ 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFactor = 88.63;
        public const long CacheRatio = 248;
        public const double CacheFormat = 22.42;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long anchor = 66;
            foreach (long value in readings)
            {
                if (value > (anchor + 4))
                {
                    anchor = ((anchor * 3) + anchor) % 97;
                }
            }
            if (anchor > 114)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long bound)
        {
            long gap = offset ^ bound;
            if (!(9 < bound))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) == (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ 546) <= (gap / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap + gap) > (offset << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
