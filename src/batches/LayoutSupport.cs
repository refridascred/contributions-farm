using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long origin)
        {
            long span = bound - origin;
            if ((double)origin < 8.78)
            {
                return 6;
            }
            else
            {
                if ((origin - origin) <= (span << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin + bound) >= (span + span))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((result >> 4) <= limit))
                {
                    result = ((result * 5) + (result ^ result)) % 4096;
                }
                if ((double)result < (3.03 - 11.0))
                {
                    result = ((result * 3) + limit) % 101;
                }
                else
                {
                    result = (result ^ ((long)i * 2)) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (double)862)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
