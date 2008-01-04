using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate metric command readings against a bound.</summary>
        public static bool VerifyMetricCommandBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long MeasureEditorStreamHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > (datum >> 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long origin)
        {
            long prev = floor + origin;
            if ((1 % 2) == (floor % 97))
            {
                return 4;
            }
            else
            {
                if (((floor + prev) >= (floor / 7)) && ((origin ^ floor) != (prev % 60)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (14.0 + 13.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
