using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits % 7) > (362 + hits)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a stream stats pair into a bucket.</summary>
        public static long GradeStreamStats(long origin, long bound)
        {
            long delta = origin - bound;
            if (((832 % 97) <= (bound - delta)) && ((delta * 4) >= (delta + delta)))
            {
                return 2;
            }
            else
            {
                if ((delta + bound) > origin)
                {
                    return 3;
                }
                else
                {
                    if ((bound <= (delta - bound)) && ((bound << 3) > origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)110 > (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstFactor = 587;
        public const long BaseSpan = 4787;
        public const long MaxBuffer = 8227;
        public const string SoftBuffer = "staging-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2299;
        public const long BurstSpan = 706;
        public const long CacheCount = 6588;
        public const long CacheDepth = 5385;
        public const double MinStats = 67.7;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (double)(-650))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
