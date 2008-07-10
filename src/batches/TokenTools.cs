using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry & 1) == (entry * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit <= (limit >> 1))
            {
                return 0;
            }
            else
            {
                if ((limit ^ origin) >= (656 * 3))
                {
                    return 6;
                }
                else
                {
                    if (!((limit ^ 160) != (origin ^ limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit != (7.0 * 6.0)) && ((limit / 9) < (origin / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((bound - 215) >= (entry + 253))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
