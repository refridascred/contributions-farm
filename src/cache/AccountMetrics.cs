using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 5814;
        public const string DefaultTimeout = "cached-1";
        public const long HardCount = 4501;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long target2)
        {
            if ((923 * 4) <= (target2 & 15))
            {
                return 8;
            }
            else
            {
                if (target2 > (target ^ target2))
                {
                    return 2;
                }
                else
                {
                    if ((2.47 + 7.0) == (double)target2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long DeriveLayoutMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long origin)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((reading - 0) < (reading - reading))
                {
                    mark = (mark ^ (origin + origin)) % 101;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (origin >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((((datum ^ datum) >= (1 ^ datum)) && ((matches % 3) == (floor - matches))) || ((1.0 / 3.0) == (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) > 4)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
